<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientStatistics.aspx.cs" Inherits="PatientStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Patient Statistics</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icon@1.11.3/font/bootstrap-icons.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>
        /* =========================================================
           ZORPZ MANAGEMENT LTD — ANALYTICS & STATISTICS SYSTEM
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
        }

        *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

        html, body {
            min-height: 100%;
            font-family: 'Jost', sans-serif;
            background-color: var(--brand-charcoal);
            color: var(--brand-cream);
            overflow-x: hidden;
        }

        /* Ambient glow backdrop background */
        body::before {
            content: '';
            position: fixed;
            inset: 0;
            background:
                radial-gradient(ellipse 80% 60% at 80% 15%, rgba(107,115,85,0.15) 0%, transparent 60%),
                radial-gradient(ellipse 60% 70% at 15% 85%, rgba(196,168,130,0.12) 0%, transparent 55%),
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

        /* ── Header Top Navigation Bar ──────────────────────── */
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

        /* ── Layout Modules ─────────────────────────────────── */
        .page-header {
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 48px 32px 24px;
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

        .page-header__title {
            font-family: 'Cormorant Garamond', serif;
            font-size: clamp(28px, 4.5vw, 42px);
            font-weight: 300;
            letter-spacing: 0.04em;
            color: var(--brand-cream);
        }

        /* Geometric divider element */
        .divider {
            display: flex;
            align-items: center;
            gap: 16px;
            margin: 0 auto 40px;
            width: min(320px, 60%);
            animation: fadeUp 0.6s ease both 0.2s;
        }

        .divider__line {
            flex: 1;
            height: 1px;
            background: linear-gradient(90deg, transparent, var(--brand-olive), transparent);
        }

        .divider__diamond {
            width: 5px;
            height: 5px;
            background: var(--brand-gold);
            transform: rotate(45deg);
        }

        /* Main analytical dashboard layout container */
        .analytics-container {
            width: min(1200px, 94vw);
            margin: 0 auto 64px;
            display: flex;
            flex-direction: column;
            gap: 24px;
            animation: fadeUp 0.65s ease both 0.3s;
        }

        /* Dashboard data metric grids */
        .analytics-grid {
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            gap: 24px;
        }

        .dashboard-card {
            border: 1px solid var(--brand-border);
            border-radius: 4px;
            background: var(--brand-panel-bg);
            backdrop-filter: blur(8px);
            overflow: hidden;
            display: flex;
            flex-direction: column;
            position: relative;
        }

        .dashboard-card::after {
            content: '';
            position: absolute;
            top: 0; left: 0; right: 0;
            height: 2px;
            background: linear-gradient(90deg, var(--brand-gold), var(--brand-olive));
        }

        .card-body {
            padding: 32px;
            flex-grow: 1;
        }

        /* Styled read-only title inputs to look like refined titles */
        .metric-title-input {
            width: 100% !important;
            background: transparent !important;
            border: none !important;
            color: var(--brand-gold) !important;
            font-family: 'Cormorant Garamond', serif !important;
            font-size: 20px !important;
            font-weight: 400 !important;
            letter-spacing: 0.03em !important;
            padding: 0 0 14px 0 !important;
            margin-bottom: 20px !important;
            border-bottom: 1px solid rgba(196, 168, 130, 0.25) !important;
            pointer-events: none; /* Make look static and non-interactive */
            outline: none !important;
        }

        /* ── GridView/Table Architecture Custom Styles ─────── */
        .gridview-container {
            width: 100%;
            overflow-x: auto;
        }

        /* Overrides the structural layout table rendering from GridView controls */
        .modern-grid {
            width: 100% !important;
            border-collapse: collapse !important;
            margin: 0 !important;
            background: transparent !important;
            border: none !important;
        }

        .modern-grid th {
            background: rgba(107, 115, 85, 0.12) !important;
            color: var(--brand-cream) !important;
            font-family: 'Jost', sans-serif !important;
            font-size: 11px !important;
            font-weight: 500 !important;
            letter-spacing: 0.1em !important;
            text-transform: uppercase !important;
            padding: 12px 16px !important;
            border-bottom: 2px solid var(--brand-olive) !important;
            border-top: none !important;
            border-left: none !important;
            border-right: none !important;
            text-align: left;
        }

        .modern-grid td {
            padding: 14px 16px !important;
            font-size: 13px !important;
            color: rgba(245, 242, 236, 0.85) !important;
            border-bottom: 1px solid rgba(107, 115, 85, 0.15) !important;
            border-top: none !important;
            border-left: none !important;
            border-right: none !important;
            transition: background 0.2s ease;
        }

        .modern-grid tr:hover td {
            background: rgba(255, 255, 255, 0.02) !important;
            color: var(--brand-white) !important;
        }

        /* ── Global Footer Control Actions Segment ──────────── */
        .action-bar {
            display: flex;
            align-items: center;
            padding: 20px 32px;
            border-top: 1px solid var(--brand-border);
            background: rgba(20, 21, 17, 0.2);
        }

        .btn-back {
            font-family: 'Jost', sans-serif;
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.14em;
            text-transform: uppercase;
            background: transparent;
            color: var(--brand-olive-light);
            border: 1px solid rgba(139, 148, 112, 0.3);
            border-radius: 3px;
            padding: 10px 24px;
            cursor: pointer;
            transition: all 0.25s ease;
            outline: none;
        }

        .btn-back:hover {
            color: var(--brand-gold-light);
            border-color: var(--brand-gold);
            background: rgba(196, 168, 130, 0.05);
        }

        .btn-back:active { transform: translateY(1px); }

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
            from { opacity: 0; transform: translateY(16px); }
            to   { opacity: 1; transform: translateY(0); }
        }

        /* Layout responsive adaptations */
        @media (max-width: 992px) {
            .analytics-grid { grid-template-columns: 1fr; gap: 24px; }
            .top-bar { padding: 0 24px; }
            .card-body { padding: 24px; }
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
            <span class="top-bar__meta">Analytics Engine Terminal</span>
        </header>

        <section class="page-header">
            <p class="page-header__eyebrow">Demographics &amp; Operations Intel</p>
            <h1 class="page-header__title">Patient Statistics</h1>
        </section>

        <div class="divider">
            <div class="divider__line"></div>
            <div class="divider__diamond"></div>
            <div class="divider__line"></div>
        </div>

        <main class="analytics-container">
            <div class="analytics-grid" id="tblGroupedByGender">
                
                <div class="dashboard-card">
                    <div class="card-body">
                        <asp:TextBox ID="txtGroupedByPatientender" runat="server" ReadOnly="true" CssClass="metric-title-input">Patient List - Grouped By Patient Gender</asp:TextBox>
                        <div class="gridview-container">
                            <asp:GridView ID="GridViewStGroupByPatientgender" runat="server" GridLines="None" CssClass="modern-grid">
                            </asp:GridView>
                        </div>
                    </div>
                </div>

                <div class="dashboard-card">
                    <div class="card-body">
                        <asp:TextBox ID="txtGroupedByPatientregistrationdate" runat="server" ReadOnly="true" CssClass="metric-title-input">Patient List - Grouped By Patient Registration Date</asp:TextBox>
                        <div class="gridview-container">
                            <asp:GridView ID="GridViewStGroupByPatientregistrationdate" runat="server" GridLines="None" CssClass="modern-grid">
                            </asp:GridView>
                        </div>
                    </div>
                </div>

            </div>

            <div class="dashboard-card">
                <div class="action-bar">
                    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="&larr; Back to Registry View" CssClass="btn-back" />
                </div>
            </div>
        </main>

        <footer class="footer">
            <span class="footer__copy">&copy; <%= DateTime.Now.Year %> Zorpz Management Ltd. All rights reserved.</span>
            <span class="footer__version">HMS Intelligence Module v1.0</span>
        </footer>

    </div>
    </form>

</body>

</html>
