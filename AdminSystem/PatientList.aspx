<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Patient List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>
        /* =========================================================
           ZORPZ MANAGEMENT LTD — PATIENT LIST MODULE
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

        /* ── Background texture ─────────────────────────── */
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

        .page-wrapper {
            position: relative;
            z-index: 1;
            min-height: 100vh;
            display: flex;
            flex-direction: column;
        }

        /* ── Top bar ─────────────────────────────────────────── */
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
            width: 24px;
            height: 24px;
            stroke: var(--brand-olive-light);
            fill: none;
            stroke-width: 1.5;
        }

        .page-header__title {
            font-family: 'Cormorant Garamond', serif;
            font-size: clamp(26px, 4vw, 40px);
            font-weight: 300;
            letter-spacing: 0.04em;
            color: var(--brand-cream);
            margin-bottom: 8px;
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

        /* ── Main card container ─────────────────────────────── */
        .dashboard-card {
            width: min(840px, 92vw);
            margin: 0 auto 64px;
            border: 1px solid var(--brand-border);
            border-radius: 4px;
            background: rgba(30,31,26,0.6);
            backdrop-filter: blur(8px);
            overflow: hidden;
            animation: fadeUp 0.65s ease both 0.4s;
            position: relative;
        }

        .dashboard-card::after {
            content: '';
            position: absolute;
            top: 0; left: 0; right: 0;
            height: 2px;
            background: linear-gradient(90deg, var(--brand-olive), var(--brand-gold));
        }

        .card-body {
            padding: 40px;
        }

        /* ── Modern ListBox Overrides ────────────────────────── */
        .listbox-wrapper {
            margin-bottom: 24px;
        }

        .modern-listbox {
            width: 100% !important;
            height: 280px !important;
            background: rgba(20,21,17,0.7) !important;
            border: 1px solid var(--brand-border) !important;
            border-radius: 4px !important;
            color: var(--brand-cream) !important;
            padding: 12px !important;
            font-family: 'Jost', sans-serif !important;
            font-size: 14px !important;
            letter-spacing: 0.03em;
            outline: none !important;
            transition: border-color 0.25s ease;
        }

        .modern-listbox:focus {
            border-color: var(--brand-olive-light) !important;
            box-shadow: 0 0 0 3px rgba(107,115,85,0.12);
        }

        /* Styling the option items inside listbox */
        .modern-listbox option {
            padding: 10px 14px;
            border-radius: 2px;
            margin-bottom: 4px;
            cursor: pointer;
            background: transparent;
            transition: background 0.15s;
        }

        .modern-listbox option:hover {
            background: rgba(139,148,112,0.15) !important;
        }

        .modern-listbox option:selected,
        .modern-listbox option:checked {
            background: var(--brand-olive) !important;
            color: var(--brand-white) !important;
        }

        /* ── Record Management Action Row ────────────────────── */
        .record-actions {
            display: flex;
            gap: 12px;
            margin-bottom: 36px;
            border-bottom: 1px dashed var(--brand-border);
            padding-bottom: 24px;
        }

        /* ── Filter Engine Section ───────────────────────────── */
        .filter-section {
            background: rgba(255,255,255,0.02);
            border: 1px solid rgba(107,115,85,0.15);
            border-radius: 4px;
            padding: 24px;
            margin-bottom: 20px;
        }

        .filter-section__title {
            font-size: 10px;
            font-weight: 500;
            letter-spacing: 0.2em;
            text-transform: uppercase;
            color: var(--brand-gold);
            margin-bottom: 16px;
        }

        .filter-row {
            display: grid;
            grid-template-columns: 1fr auto;
            gap: 16px;
            align-items: flex-end;
        }

        .field {
            display: flex;
            flex-direction: column;
            gap: 8px;
        }

        .field__label {
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.12em;
            text-transform: uppercase;
            color: var(--brand-olive-light);
        }

        .aspnet-input {
            width: 100%;
            background: rgba(255,255,255,0.04);
            border: 1px solid var(--brand-border);
            border-radius: 3px;
            padding: 10px 14px;
            font-family: 'Jost', sans-serif;
            font-size: 13px;
            color: var(--brand-cream);
            outline: none;
            transition: border-color 0.25s, background 0.25s;
        }

        .aspnet-input:focus {
            border-color: var(--brand-olive-light);
            background: rgba(107,115,85,0.08);
        }

        .filter-buttons {
            display: flex;
            gap: 10px;
        }

        /* ── Error label styling ─────────────────────────────── */
        .error-msg {
            font-size: 12px;
            font-weight: 300;
            color: var(--brand-error);
            display: block;
            margin-top: 14px;
            min-height: 18px;
        }

        /* ── Navigation Bottom Bar ───────────────────────────── */
        .action-bar {
            display: flex;
            align-items: center;
            gap: 12px;
            padding: 24px 40px 36px;
            border-top: 1px solid var(--brand-border);
            flex-wrap: wrap;
        }

        /* Button Framework */
        .btn {
            font-family: 'Jost', sans-serif;
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.14em;
            text-transform: uppercase;
            border: none;
            border-radius: 3px;
            padding: 10px 24px;
            cursor: pointer;
            transition: all 0.25s ease;
            outline: none;
        }

        .btn:active { transform: translateY(1px); }

        .btn-primary {
            background: var(--brand-olive);
            color: var(--brand-cream);
            border: 1px solid var(--brand-olive-dark);
        }
        .btn-primary:hover {
            background: var(--brand-olive-light);
            box-shadow: 0 4px 12px rgba(107,115,85,0.2);
        }

        .btn-secondary {
            background: transparent;
            color: var(--brand-gold);
            border: 1px solid rgba(196,168,130,0.3);
        }
        .btn-secondary:hover {
            background: rgba(196,168,130,0.08);
            border-color: var(--brand-gold);
        }

        .btn-danger {
            background: transparent;
            color: var(--brand-error);
            border: 1px solid rgba(196,130,106,0.3);
        }
        .btn-danger:hover {
            background: rgba(196,130,106,0.08);
            border-color: var(--brand-error);
        }

        .btn-return {
            background: transparent;
            color: var(--brand-olive-light);
            border: none;
            padding: 10px 0;
            margin-left: auto;
        }
        .btn-return:hover { color: var(--brand-gold-light); }

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

        .footer__copy { font-size: 11px; color: rgba(107,115,85,0.6); letter-spacing: 0.05em;}
        .footer__version { font-size: 11px; color: rgba(107,115,85,0.4); }

        @keyframes fadeUp {
            from { opacity: 0; transform: translateY(20px); }
            to   { opacity: 1; transform: translateY(0); }
        }

        /* Responsive Breakpoints */
        @media (max-width: 768px) {
            .card-body { padding: 24px; }
            .filter-row { grid-template-columns: 1fr; }
            .filter-buttons { width: 100%; justify-content: flex-start; }
            .action-bar { padding: 20px 24px; }
            .btn-return { margin-left: 0; width: 100%; text-align: left; padding: 8px 0; }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page-wrapper">

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

        <section class="page-header">
            <p class="page-header__eyebrow">Patient Database Master View</p>
            <div class="page-header__icon">
                <svg viewBox="0 0 24 24" fill="none" stroke="currentColor"><path stroke-linecap="round" stroke-linejoin="round" d="M9 12h6m-6 4h6m2 5H7a2 2 0 01-2-2V5a2 2 0 012-2h5.586a1 1 0 01.707.293l5.414 5.414a1 1 0 01.293.707V19a2 2 0 01-2 2z" /></svg>
            </div>
            <h1 class="page-header__title">Patient <em>Registry</em></h1>
            <p class="page-header__sub">Browse records, filter data, and access health diagnostics</p>
        </section>

        <div class="divider">
            <div class="divider__line"></div>
            <div class="divider__diamond"></div>
            <div class="divider__line"></div>
        </div>

        <div class="dashboard-card">
            <div class="card-body">

                <div class="listbox-wrapper">
                    <asp:ListBox ID="lstPatientList" runat="server" CssClass="modern-listbox"></asp:ListBox>
                </div>

                <div class="record-actions">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Record" CssClass="btn btn-primary" />
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Modify Selection" CssClass="btn btn-secondary" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Remove" CssClass="btn btn-danger" />
                </div>

                <div class="filter-section">
                    <div class="filter-section__title">Query Configuration</div>
                    <div class="filter-row">
                        <div class="field">
                            <asp:Label ID="lblEnterPatientfullname" runat="server" AssociatedControlID="txtFilter" CssClass="field__label" Text="Search by Patient Name"></asp:Label>
                            <asp:TextBox ID="txtFilter" runat="server" CssClass="aspnet-input" placeholder="Enter criteria name..." />
                        </div>
                        <div class="filter-buttons">
                            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Filter" CssClass="btn btn-secondary" />
                            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Reset" CssClass="btn btn-ghost" style="color: var(--brand-olive-light); border: 1px solid var(--brand-border);" />
                        </div>
                    </div>
                </div>

                <asp:Label ID="lblError" runat="server" CssClass="error-msg" />

            </div>

            <div class="action-bar">
                <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" Text="Analytics &amp; Statistics" CssClass="btn btn-secondary" />
                <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="&larr; Return to Main Menu" CssClass="btn btn-return" />
            </div>
        </div>

        <footer class="footer">
            <span class="footer__copy">&copy; <%= DateTime.Now.Year %> Zorpz Management Ltd. All rights reserved.</span>
            <span class="footer__version">HMS v1.0</span>
        </footer>

    </div>
   
        </form>

</body>

</html>
