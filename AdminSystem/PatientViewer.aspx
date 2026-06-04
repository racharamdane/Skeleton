<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Patient Profile Viewer</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>
        /* =========================================================
           ZORPZ MANAGEMENT LTD — REGISTRY DOCUMENT VIEW SYSTEM
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

        body::before {
            content: '';
            position: fixed;
            inset: 0;
            background:
                radial-gradient(ellipse 80% 60% at 50% 15%, rgba(107,115,85,0.14) 0%, transparent 65%),
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

        .viewer-container {
            flex: 1;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 40px 24px;
            animation: fadeIn 0.8s ease both;
        }

        .viewer-card {
            width: min(640px, 100%);
            border: 1px solid var(--brand-border);
            border-radius: 4px;
            background: var(--brand-panel-bg);
            backdrop-filter: blur(8px);
            position: relative;
            overflow: hidden;
            text-align: center;
        }

        .viewer-card::after {
            content: '';
            position: absolute;
            top: 0; left: 0; right: 0;
            height: 2px;
            background: linear-gradient(90deg, var(--brand-olive), var(--brand-gold));
        }

        .viewer-body {
            padding: 48px 40px;
        }

        .viewer-icon {
            width: 64px;
            height: 64px;
            border-radius: 50%;
            border: 1px solid var(--brand-border);
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0 auto 24px;
            background: rgba(107,115,85,0.08);
            color: var(--brand-gold);
            font-size: 24px;
        }

        .viewer-title {
            font-family: 'Cormorant Garamond', serif;
            font-size: 28px;
            font-weight: 300;
            letter-spacing: 0.04em;
            color: var(--brand-cream);
            margin-bottom: 8px;
        }

        .viewer-description {
            font-size: 13px;
            color: var(--brand-olive-light);
            letter-spacing: 0.05em;
            max-width: 360px;
            margin: 0 auto 24px;
            line-height: 1.6;
        }

        /* Profile details container layout */
        .patient-summary-box {
            text-align: left;
            background: rgba(0,0,0,0.2);
            padding: 24px;
            border-radius: 4px;
            border: 1px solid var(--brand-border);
        }

        .summary-item {
            margin-bottom: 14px;
            border-bottom: 1px dashed rgba(139,148,112,0.15);
            padding-bottom: 10px;
        }

        .summary-item:last-child {
            margin-bottom: 0;
            border-bottom: none;
            padding-bottom: 0;
        }

        .summary-item__label {
            font-size: 10px;
            text-transform: uppercase;
            color: var(--brand-gold);
            letter-spacing: 0.08em;
            display: block;
            margin-bottom: 2px;
        }

        .summary-item__value {
            font-size: 15px;
            font-weight: 300;
            color: var(--brand-cream);
        }

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

        @keyframes fadeIn {
            from { opacity: 0; transform: scale(0.98) translateY(10px); }
            to   { opacity: 1; transform: scale(1) translateY(0); }
        }

        @media (max-width: 576px) {
            .top-bar { padding: 0 24px; }
            .viewer-body { padding: 36px 20px; }
            .footer { padding: 14px 24px; }
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
            <span class="top-bar__meta">Document Core Sandbox</span>
        </header>

        <main class="viewer-container">
            <div class="viewer-card">
                <div class="viewer-body">
                    
                    <div class="viewer-icon">
                        <i class="bi bi-file-earmark-medical"></i>
                    </div>
                    <h2 class="viewer-title">Patient Profile Summary</h2>
                    <p class="viewer-description">Active session registry entry validation overview</p>

                    <div class="patient-summary-box">
                        <div class="summary-item">
                            <span class="summary-item__label">Full Name</span>
                            <asp:Label ID="lblFullName" runat="server" CssClass="summary-item__value" />
                        </div>

                        <div class="summary-item">
                            <span class="summary-item__label">Registration Date</span>
                            <asp:Label ID="lblDateAdded" runat="server" CssClass="summary-item__value" />
                        </div>

                        <div class="summary-item">
                            <span class="summary-item__label">Email Address</span>
                            <asp:Label ID="lblEmail" runat="server" CssClass="summary-item__value" />
                        </div>

                        <div class="summary-item">
                            <span class="summary-item__label">Assigned Gender</span>
                            <asp:Label ID="lblGender" runat="server" CssClass="summary-item__value" />
                        </div>

                        <div class="summary-item">
                            <span class="summary-item__label">Prescribed Treatment Track</span>
                            <asp:Label ID="lblTreatment" runat="server" CssClass="summary-item__value" />
                        </div>
                    </div>

                    <div style="margin-top: 32px; display: flex; justify-content: center;">
                        <asp:Button ID="btnReturnToMain" runat="server" 
                                    OnClick="btnReturnToMain_Click" 
                                    Text="&larr; Return to Patient List" 
                                    style="font-family: 'Jost', sans-serif; font-size: 11px; font-weight: 400; letter-spacing: 0.14em; text-transform: uppercase; background: var(--brand-olive); color: var(--brand-cream); border: 1px solid var(--brand-olive-dark); border-radius: 3px; padding: 12px 28px; cursor: pointer; transition: all 0.25s ease; outline: none;"
                                    onmouseover="this.style.background='var(--brand-olive-light)'"
                                    onmouseout="this.style.background='var(--brand-olive)'" />
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
