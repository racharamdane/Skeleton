<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Confirm Destruction</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>
        /* =========================================================
           ZORPZ MANAGEMENT LTD — REGISTRY RECORD DELETION INTERFACE
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
            --brand-panel-bg:    rgba(30,31,26,0.6);
            --brand-error:       #C4826A;
        }

        *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

        html, body {
            min-height: 100%;
            font-family: 'Jost', sans-serif;
            background-color: var(--brand-charcoal);
            color: var(--brand-cream);
            overflow-x: hidden;
        }

        /* Ambient warning backdrop aesthetic overlay */
        body::before {
            content: '';
            position: fixed;
            inset: 0;
            background:
                radial-gradient(ellipse 80% 60% at 50% 30%, rgba(196,130,106,0.08) 0%, transparent 65%),
                repeating-linear-gradient(
                    0deg,
                    transparent,
                    transparent 2px,
                    rgba(255,255,255,0.01) 2px,
                    rgba(255,255,255,0.01) 4px
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

        /* ── Top Header Brand Strip ─────────────────────────── */
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

        /* ── Center Dialog Elements ──────────────────────────── */
        .dialog-container {
            flex: 1;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 40px 24px;
            animation: warningPop 0.65s cubic-bezier(0.16, 1, 0.3, 1) both;
        }

        .dialog-card {
            width: min(520px, 100%);
            border: 1px solid rgba(196,130,106,0.25);
            border-radius: 4px;
            background: var(--brand-panel-bg);
            backdrop-filter: blur(10px);
            position: relative;
            overflow: hidden;
            text-align: center;
            box-shadow: 0 20px 50px rgba(0,0,0,0.3);
        }

        /* Crimson Warning top indicator bar */
        .dialog-card::after {
            content: '';
            position: absolute;
            top: 0; left: 0; right: 0;
            height: 3px;
            background: linear-gradient(90deg, var(--brand-error), var(--brand-gold));
        }

        .dialog-body {
            padding: 48px 40px;
        }

        .warning-icon {
            width: 64px;
            height: 64px;
            border-radius: 50%;
            border: 1px solid rgba(196,130,106,0.3);
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0 auto 24px;
            background: rgba(196,130,106,0.06);
            color: var(--brand-error);
            font-size: 26px;
            animation: pulseWarning 2.5s infinite alternate;
        }

        .dialog-title {
            font-family: 'Cormorant Garamond', serif;
            font-size: 28px;
            font-weight: 300;
            letter-spacing: 0.04em;
            color: var(--brand-cream);
            margin-bottom: 12px;
        }

        /* Modernized wrapper layout rule for the primary message label */
        .confirm-msg-label {
            font-size: 14px !important;
            color: rgba(245,242,236,0.8) !important;
            letter-spacing: 0.04em;
            line-height: 1.6;
            display: block;
            margin-bottom: 32px;
            font-weight: 300;
        }

        /* ── Structured Interactive Actions Bar ────────────────── */
        .actions-group {
            display: flex;
            gap: 16px;
            justify-content: center;
        }

        .btn-action {
            font-family: 'Jost', sans-serif;
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.16em;
            text-transform: uppercase;
            border-radius: 3px;
            padding: 12px 32px;
            cursor: pointer;
            transition: all 0.25s ease;
            outline: none;
            min-width: 140px;
        }

        .btn-action:active { transform: translateY(1px); }

        /* YES: Absolute destructive confirm path button */
        .btn-confirm-yes {
            background: var(--brand-error);
            color: var(--brand-white);
            border: 1px solid #A8654F;
        }
        .btn-confirm-yes:hover {
            background: #D4937B;
            box-shadow: 0 4px 15px rgba(196,130,106,0.25);
        }

        /* NO: Standard non-destructive abort option button */
        .btn-confirm-no {
            background: transparent;
            color: var(--brand-olive-light);
            border: 1px solid var(--brand-border);
        }
        .btn-confirm-no:hover {
            border-color: var(--brand-gold);
            color: var(--brand-gold-light);
            background: rgba(196,168,130,0.06);
        }

        /* ── Global Footer System ────────────────────────────── */
        .footer {
            margin-top: auto;
            padding: 18px 48px;
            border-top: 1px solid var(--brand-border);
            display: flex;
            align-items: center;
            justify-content: space-between;
            background: rgba(20,21,17,0.6);
        }

        .footer__copy { font-size: 11px; color: rgba(107,115,85,0.6); letter-spacing: 0.05em; }
        .footer__version { font-size: 11px; color: rgba(107,115,85,0.4); }

        @keyframes warningPop {
            from { opacity: 0; transform: scale(0.96) translateY(12px); }
            to   { opacity: 1; transform: scale(1) translateY(0); }
        }

        @keyframes pulseWarning {
            0% { box-shadow: 0 0 0 0 rgba(196,130,106,0.2); }
            100% { box-shadow: 0 0 0 10px rgba(196,130,106,0); }
        }

        @media (max-width: 576px) {
            .top-bar { padding: 0 24px; }
            .dialog-body { padding: 36px 24px; }
            .actions-group { flex-direction: column; gap: 12px; }
            .btn-action { width: 100%; }
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
            <span class="top-bar__meta">Security Access Protocol</span>
        </header>

        <main class="dialog-container">
            <div class="dialog-card">
                <div class="dialog-body">
                    
                    <div class="warning-icon">
                        <i class="bi bi-exclamation-triangle"></i>
                    </div>
                    
                    <h2 class="dialog-title">Confirm Deletion</h2>
                    
                    <asp:Label ID="lblError" runat="server" CssClass="confirm-msg-label" 
                        Text="Are you sure you want to permanently delete this patient record? This action cannot be undone.">
                    </asp:Label>
                    
                    <div class="actions-group">
                        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes, Delete" CssClass="btn-action btn-confirm-yes" />
                        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No, Cancel" CssClass="btn-action btn-confirm-no" />
                    </div>

                </div>
            </div>
        </main>

        <footer class="footer">
            <span class="footer__copy">&copy; <%= DateTime.Now.Year %> Zorpz Management Ltd. All rights reserved.</span>
            <span class="footer__version">HMS v1.0</span>
        </footer>

    </div>
  
        </form>
</body>
</html>
