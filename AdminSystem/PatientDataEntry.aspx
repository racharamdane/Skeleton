<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Patient Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>

        /* =========================================================
           ZORPZ MANAGEMENT LTD — PATIENT DATA ENTRY
           ========================================================= */
        :root {
            --brand-olive:       #6B7355;
            --brand-olive-dark:  #4A5040;
            --brand-olive-light: #8B9470;
            --brand-cream:       #F5F2EC;
            --brand-charcoal:    #1E1F1A;
            --brand-gold:        #C4A882;
            --brand-gold-light:  #D4BC9A;
            --brand-white:       #FAFAF8;
            --brand-border:      rgba(107,115,85,0.25);
            --brand-error:       #C4826A;
            --brand-success:     #7A9470;
        }

        *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

        html, body {
            min-height: 100%;
            font-family: 'Jost', sans-serif;
            background-color: var(--brand-charcoal);
            color: var(--brand-cream);
            overflow-x: hidden;
        }

        /* ── Background texture (same as main menu) ─────────── */
        body::before {
            content: '';
            position: fixed;
            inset: 0;
            background:
                radial-gradient(ellipse 80% 60% at 20% 10%, rgba(107,115,85,0.18) 0%, transparent 60%),
                radial-gradient(ellipse 60% 70% at 85% 80%, rgba(74,80,64,0.22) 0%, transparent 55%),
                repeating-linear-gradient(
                    0deg,
                    transparent,
                    transparent 2px,
                    rgba(255,255,255,0.012) 2px,
                    rgba(255,255,255,0.012) 4px
                );
            pointer-events: none;
            z-index: 0;
        }

        /* ── Layout wrapper ──────────────────────────────────── */
        .page-wrapper {
            position: relative;
            z-index: 1;
            min-height: 100vh;
            display: flex;
            flex-direction: column;
        }

        /* ── Top bar (identical to main menu) ───────────────── */
        .top-bar {
            display: flex;
            align-items: center;
            justify-content: space-between;
            padding: 0 48px;
            height: 72px;
            border-bottom: 1px solid var(--brand-border);
            background: rgba(30,31,26,0.85);
            backdrop-filter: blur(12px);
        }

        .top-bar__brand {
            display: flex;
            align-items: center;
            gap: 14px;
        }

        .top-bar__logo {
            width: 44px;
            height: 44px;
            border-radius: 8px;
            object-fit: cover;
            border: 1px solid var(--brand-olive);
        }

        .top-bar__name {
            font-family: 'Cormorant Garamond', serif;
            font-size: 18px;
            font-weight: 500;
            letter-spacing: 0.06em;
            color: var(--brand-cream);
        }

        .top-bar__name span { color: var(--brand-gold); }

        .top-bar__meta {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.12em;
            color: var(--brand-olive-light);
            text-transform: uppercase;
        }

        /* ── Page header ─────────────────────────────────────── */
        .page-header {
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 48px 32px 32px;
            text-align: center;
            animation: fadeUp 0.7s ease both 0.1s;
        }

        .page-header__eyebrow {
            font-size: 11px;
            font-weight: 300;
            letter-spacing: 0.22em;
            text-transform: uppercase;
            color: var(--brand-gold);
            margin-bottom: 12px;
        }

        .page-header__icon {
            width: 56px;
            height: 56px;
            border-radius: 50%;
            border: 1px solid var(--brand-border);
            display: flex;
            align-items: center;
            justify-content: center;
            margin-bottom: 16px;
            background: rgba(107,115,85,0.08);
        }

        .page-header__icon svg {
            width: 26px;
            height: 26px;
            stroke: var(--brand-olive-light);
            fill: none;
            stroke-width: 1.4;
            stroke-linecap: round;
            stroke-linejoin: round;
        }

        .page-header__title {
            font-family: 'Cormorant Garamond', serif;
            font-size: clamp(26px, 4vw, 40px);
            font-weight: 300;
            letter-spacing: 0.04em;
            color: var(--brand-cream);
            margin-bottom: 8px;
        }

        .page-header__title em {
            font-style: italic;
            color: var(--brand-gold-light);
        }

        .page-header__sub {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.14em;
            text-transform: uppercase;
            color: var(--brand-olive-light);
        }

        /* ── Divider ─────────────────────────────────────────── */
        .divider {
            display: flex;
            align-items: center;
            gap: 16px;
            margin: 0 auto 36px;
            width: min(480px, 80%);
            animation: fadeUp 0.6s ease both 0.3s;
        }

        .divider__line {
            flex: 1;
            height: 1px;
            background: linear-gradient(90deg, transparent, var(--brand-olive), transparent);
        }

        .divider__diamond {
            width: 6px;
            height: 6px;
            background: var(--brand-gold);
            transform: rotate(45deg);
        }

        /* ── Form card ───────────────────────────────────────── */
        .form-card {
            width: min(760px, 92vw);
            margin: 0 auto 64px;
            border: 1px solid var(--brand-border);
            border-radius: 4px;
            background: rgba(30,31,26,0.6);
            backdrop-filter: blur(8px);
            overflow: hidden;
            animation: fadeUp 0.65s ease both 0.4s;
            position: relative;
        }

        .form-card::before {
            content: '';
            position: absolute;
            inset: 0;
            background: linear-gradient(135deg, rgba(107,115,85,0.07) 0%, transparent 60%);
            pointer-events: none;
        }

        .form-card::after {
            content: '';
            position: absolute;
            top: 0; left: 0; right: 0;
            height: 2px;
            background: linear-gradient(90deg, var(--brand-olive), var(--brand-gold));
        }

        /* ── Form sections ───────────────────────────────────── */
        .form-body {
            padding: 36px 40px 32px;
        }

        .form-section {
            margin-bottom: 28px;
        }

        .form-section__label {
            font-size: 10px;
            font-weight: 400;
            letter-spacing: 0.2em;
            text-transform: uppercase;
            color: var(--brand-gold);
            margin-bottom: 16px;
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .form-section__label::after {
            content: '';
            flex: 1;
            height: 1px;
            background: var(--brand-border);
        }

        .form-row {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 16px;
            margin-bottom: 16px;
        }

        .form-row.full { grid-template-columns: 1fr; }

        /* ── Field group ─────────────────────────────────────── */
        .field {
            display: flex;
            flex-direction: column;
            gap: 6px;
        }

        .field__label {
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.12em;
            text-transform: uppercase;
            color: var(--brand-olive-light);
        }

        /* All ASP.NET TextBox inputs */
        .field input[type="text"],
        .field input[type="password"],
        .field input[type="email"],
        .aspnet-input {
            width: 100%;
            background: rgba(255,255,255,0.04);
            border: 1px solid var(--brand-border);
            border-radius: 3px;
            padding: 10px 14px;
            font-family: 'Jost', sans-serif;
            font-size: 13px;
            font-weight: 300;
            color: var(--brand-cream);
            letter-spacing: 0.04em;
            outline: none;
            transition: border-color 0.25s ease, background 0.25s ease, box-shadow 0.25s ease;
        }

        .field input[type="text"]:focus,
        .field input[type="password"]:focus,
        .field input[type="email"]:focus,
        .aspnet-input:focus {
            border-color: var(--brand-olive-light);
            background: rgba(107,115,85,0.08);
            box-shadow: 0 0 0 3px rgba(107,115,85,0.12);
        }

        .field input::placeholder { color: rgba(139,148,112,0.45); }

        /* ── Gender select ───────────────────────────────────── */
        .field select {
            width: 100%;
            background: rgba(255,255,255,0.04);
            border: 1px solid var(--brand-border);
            border-radius: 3px;
            padding: 10px 14px;
            font-family: 'Jost', sans-serif;
            font-size: 13px;
            font-weight: 300;
            color: var(--brand-cream);
            letter-spacing: 0.04em;
            outline: none;
            appearance: none;
            cursor: pointer;
            transition: border-color 0.25s ease, background 0.25s ease;
        }

        .field select:focus {
            border-color: var(--brand-olive-light);
            background: rgba(107,115,85,0.08);
        }

        .select-wrapper {
            position: relative;
        }

        .select-wrapper::after {
            content: '';
            position: absolute;
            right: 14px;
            top: 50%;
            transform: translateY(-50%);
            width: 0;
            height: 0;
            border-left: 4px solid transparent;
            border-right: 4px solid transparent;
            border-top: 5px solid var(--brand-olive-light);
            pointer-events: none;
        }

        /* ── Checkbox ────────────────────────────────────────── */
        .checkbox-field {
            display: flex;
            align-items: center;
            gap: 10px;
            padding: 12px 14px;
            border: 1px solid var(--brand-border);
            border-radius: 3px;
            background: rgba(255,255,255,0.03);
            cursor: pointer;
            transition: border-color 0.2s, background 0.2s;
        }

        .checkbox-field:hover {
            border-color: var(--brand-olive-light);
            background: rgba(107,115,85,0.06);
        }

        .checkbox-field input[type="checkbox"] {
            appearance: none;
            width: 16px;
            height: 16px;
            border: 1px solid var(--brand-olive);
            border-radius: 2px;
            background: transparent;
            cursor: pointer;
            flex-shrink: 0;
            position: relative;
            transition: background 0.2s, border-color 0.2s;
        }

        .checkbox-field input[type="checkbox"]:checked {
            background: var(--brand-olive);
            border-color: var(--brand-olive);
        }

        .checkbox-field input[type="checkbox"]:checked::after {
            content: '';
            position: absolute;
            left: 4px; top: 1px;
            width: 5px; height: 9px;
            border: 1.5px solid var(--brand-cream);
            border-left: none;
            border-top: none;
            transform: rotate(40deg);
        }

        .checkbox-field__text {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.08em;
            color: var(--brand-cream);
        }

        /* ── Error label ─────────────────────────────────────── */
        .error-msg {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.06em;
            color: var(--brand-error);
            min-height: 20px;
            padding: 0 4px;
        }

        /* ── Action bar ──────────────────────────────────────── */
        .action-bar {
            display: flex;
            align-items: center;
            gap: 12px;
            padding: 24px 40px 36px;
            border-top: 1px solid var(--brand-border);
            flex-wrap: wrap;
        }

        /* Shared button base */
        .btn {
            font-family: 'Jost', sans-serif;
            font-size: 12px;
            font-weight: 400;
            letter-spacing: 0.16em;
            text-transform: uppercase;
            border: none;
            border-radius: 3px;
            padding: 11px 28px;
            cursor: pointer;
            transition: background 0.25s ease, color 0.25s ease, transform 0.2s ease, box-shadow 0.25s ease;
            outline: none;
        }

        .btn:active { transform: translateY(1px); }

        /* Primary — OK */
        .btn-primary {
            background: var(--brand-olive);
            color: var(--brand-cream);
            border: 1px solid var(--brand-olive-dark);
        }

        .btn-primary:hover {
            background: var(--brand-olive-light);
            box-shadow: 0 6px 20px rgba(107,115,85,0.3);
        }

        /* Secondary — Find */
        .btn-secondary {
            background: transparent;
            color: var(--brand-gold);
            border: 1px solid rgba(196,168,130,0.35);
        }

        .btn-secondary:hover {
            background: rgba(196,168,130,0.08);
            border-color: var(--brand-gold);
        }

        /* Ghost — Cancel */
        .btn-ghost {
            background: transparent;
            color: var(--brand-olive-light);
            border: 1px solid var(--brand-border);
        }

        .btn-ghost:hover {
            color: var(--brand-cream);
            border-color: var(--brand-olive-light);
            background: rgba(255,255,255,0.04);
        }

        /* Return — text link style */
        .btn-return {
            background: transparent;
            color: var(--brand-olive-light);
            border: none;
            padding: 11px 0;
            font-size: 11px;
            letter-spacing: 0.18em;
            margin-left: auto;
            display: flex;
            align-items: center;
            gap: 6px;
        }

        .btn-return:hover { color: var(--brand-gold-light); }

        .btn-return svg {
            width: 14px;
            height: 14px;
            stroke: currentColor;
            fill: none;
            stroke-width: 1.5;
            stroke-linecap: round;
            stroke-linejoin: round;
        }

        /* ASP.NET button overrides */
        input[type="submit"],
        input[type="button"],
        button {
            font-family: 'Jost', sans-serif;
        }

        /* ── Footer ──────────────────────────────────────────── */
        .footer {
            margin-top: auto;
            padding: 18px 48px;
            border-top: 1px solid var(--brand-border);
            display: flex;
            align-items: center;
            justify-content: space-between;
            background: rgba(20,21,17,0.6);
        }

        .footer__copy {
            font-size: 11px;
            font-weight: 300;
            letter-spacing: 0.1em;
            color: rgba(107,115,85,0.6);
        }

        .footer__version {
            font-size: 11px;
            letter-spacing: 0.12em;
            color: rgba(107,115,85,0.4);
        }

        /* ── Animations ──────────────────────────────────────── */
        @keyframes fadeUp {
            from { opacity: 0; transform: translateY(22px); }
            to   { opacity: 1; transform: translateY(0);    }
        }

        /* ── Responsive ──────────────────────────────────────── */
        @media (max-width: 600px) {
            .form-body { padding: 24px 20px 20px; }
            .form-row  { grid-template-columns: 1fr; }
            .action-bar { padding: 20px 20px 28px; }
            .top-bar { padding: 0 20px; }
            .footer  { padding: 14px 20px; }
            .btn-return { margin-left: 0; width: 100%; }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page-wrapper">

        <!-- ── Top bar ───────────────────────────────────── -->
        <header class="top-bar">
            <div class="top-bar__brand">
                <asp:Image ID="imgLogoBar" runat="server"
                    ImageUrl="~/team_logo.jfif"
                    AlternateText="Zorpz Management Ltd"
                    CssClass="top-bar__logo" />
                <span class="top-bar__name">Zorpz <span>Management</span> Ltd</span>
            </div>
            <span class="top-bar__meta">Healthcare Management System</span>
        </header>

        <!-- ── Page header ───────────────────────────────── -->
        <section class="page-header">
            <p class="page-header__eyebrow">Patient Records Module</p>
            <div class="page-header__icon">
                <svg viewBox="0 0 24 24"><path d="M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2"/><circle cx="12" cy="7" r="4"/></svg>
            </div>
            <h1 class="page-header__title">Patient <em>Data Entry</em></h1>
            <p class="page-header__sub">Create or update a patient record</p>
        </section>

        <!-- ── Divider ───────────────────────────────────── -->
        <div class="divider">
            <div class="divider__line"></div>
            <div class="divider__diamond"></div>
            <div class="divider__line"></div>
        </div>

        <!-- ── Form card ─────────────────────────────────── -->
        <div class="form-card">
            <div class="form-body">

                <!-- Section: Identity -->
                <div class="form-section">
                    <div class="form-section__label">Identity</div>

                    <div class="form-row">
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientID.ClientID %>">Patient ID</label>
                            <asp:TextBox ID="txtPatientID" runat="server"
                                CssClass="aspnet-input"
                                placeholder="e.g. PAT-00123" />
                        </div>
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientregistrationdate.ClientID %>">Registration Date</label>
                            <asp:TextBox ID="txtPatientregistrationdate" runat="server"
                                CssClass="aspnet-input"
                                placeholder="dd/mm/yyyy" />
                        </div>
                    </div>

                    <div class="form-row full">
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientfullname.ClientID %>">Full Name</label>
                            <asp:TextBox ID="txtPatientfullname" runat="server"
                                CssClass="aspnet-input"
                                placeholder="First and last name" />
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientgender.ClientID %>">Gender</label>
                            <asp:TextBox ID="txtPatientgender" runat="server"
                                CssClass="aspnet-input"
                                placeholder="e.g. Male / Female / Other" />
                        </div>
                    </div>
                </div>

                <!-- Section: Contact & Access -->
                <div class="form-section">
                    <div class="form-section__label">Contact &amp; Access</div>

                    <div class="form-row">
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientEmail.ClientID %>">Email Address</label>
                            <asp:TextBox ID="txtPatientEmail" runat="server"
                                CssClass="aspnet-input"
                                placeholder="patient@example.com" />
                        </div>
                        <div class="field">
                            <label class="field__label" for="<%= txtPatientpassword.ClientID %>">Password</label>
                            <asp:TextBox ID="txtPatientpassword" runat="server"
                                CssClass="aspnet-input"
                                TextMode="Password"
                                placeholder="••••••••" />
                        </div>
                    </div>
                </div>

                <!-- Section: Clinical -->
                <div class="form-section">
                    <div class="form-section__label">Clinical</div>

                    <label class="checkbox-field">
                        <asp:CheckBox ID="chkPatienttreatment" runat="server" />
                        <span class="checkbox-field__text">Patient is currently receiving treatment</span>
                    </label>
                </div>

                <!-- Error message -->
                <asp:Label ID="lblError" runat="server" CssClass="error-msg" />

            </div>

            <!-- ── Action bar ─────────────────────────── -->
            <div class="action-bar">
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click"
                    Text="Save Record"
                    CssClass="btn btn-primary" />

                <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click"
                    Text="Find Patient"
                    CssClass="btn btn-secondary" />

                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click"
                    Text="Cancel"
                    CssClass="btn btn-ghost" />

                <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click"
                    Text="← Return to Main Menu"
                    CssClass="btn btn-return" />
            </div>
        </div>

        <!-- ── Footer ─────────────────────────────────── -->
        <footer class="footer">
            <span class="footer__copy">&copy; <%= DateTime.Now.Year %> Zorpz Management Ltd. All rights reserved.</span>
            <span class="footer__version">HMS v1.0</span>
        </footer>

    </div>

    </form>
</body>
</html>
