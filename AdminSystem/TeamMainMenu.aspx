<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Zorpz Management Ltd — Main Menu</title>
    <link href="https://fonts.googleapis.com/css2?family=Cormorant+Garamond:wght@300;400;500;600&family=Jost:wght@200;300;400;500&display=swap" rel="stylesheet"/>
    <style>
        /* =========================================================
           ZORPZ MANAGEMENT LTD — MAIN MENU
           Colour Palette inspired by company logo
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
        }

        *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

        html, body {
            height: 100%;
            font-family: 'Jost', sans-serif;
            background-color: var(--brand-charcoal);
            color: var(--brand-cream);
            overflow-x: hidden;
        }

        /* ── Background texture ────────────────────────────────── */
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

        /* ── Layout wrapper ────────────────────────────────────── */
        .page-wrapper {
            position: relative;
            z-index: 1;
            min-height: 100vh;
            display: flex;
            flex-direction: column;
        }

        /* ── Top bar ───────────────────────────────────────────── */
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

        .top-bar__name span {
            color: var(--brand-gold);
        }

        .top-bar__meta {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.12em;
            color: var(--brand-olive-light);
            text-transform: uppercase;
        }

        /* ── Hero section ──────────────────────────────────────── */
        .hero {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            padding: 60px 32px 40px;
            text-align: center;
        }

        .hero__eyebrow {
            font-size: 11px;
            font-weight: 300;
            letter-spacing: 0.22em;
            text-transform: uppercase;
            color: var(--brand-gold);
            margin-bottom: 18px;
        }

        .hero__logo-container {
            position: relative;
            width: 120px;
            height: 120px;
            margin-bottom: 28px;
        }

        .hero__logo-ring {
            position: absolute;
            inset: -8px;
            border-radius: 50%;
            border: 1px solid var(--brand-border);
            animation: ring-pulse 3s ease-in-out infinite;
        }

        .hero__logo-ring-outer {
            position: absolute;
            inset: -18px;
            border-radius: 50%;
            border: 1px solid rgba(107,115,85,0.12);
            animation: ring-pulse 3s ease-in-out infinite 0.8s;
        }

        @keyframes ring-pulse {
            0%, 100% { opacity: 0.4; transform: scale(1); }
            50%       { opacity: 1;   transform: scale(1.03); }
        }

        .hero__logo-img {
            width: 120px;
            height: 120px;
            border-radius: 18px;
            object-fit: cover;
            border: 2px solid var(--brand-olive);
            box-shadow: 0 8px 40px rgba(0,0,0,0.45), 0 0 0 1px rgba(196,168,130,0.15);
        }

        .hero__title {
            font-family: 'Cormorant Garamond', serif;
            font-size: clamp(32px, 5vw, 52px);
            font-weight: 300;
            letter-spacing: 0.04em;
            line-height: 1.15;
            color: var(--brand-cream);
            margin-bottom: 12px;
        }

        .hero__title em {
            font-style: italic;
            color: var(--brand-gold-light);
        }

        .hero__subtitle {
            font-size: 13px;
            font-weight: 300;
            letter-spacing: 0.14em;
            text-transform: uppercase;
            color: var(--brand-olive-light);
        }

        /* ── Divider ───────────────────────────────────────────── */
        .divider {
            display: flex;
            align-items: center;
            gap: 16px;
            margin: 20px auto 40px;
            width: min(480px, 80%);
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

        /* ── Navigation grid ───────────────────────────────────── */
        .nav-grid {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            grid-template-rows: auto auto;
            gap: 20px;
            width: min(900px, 90vw);
            margin: 0 auto;
            padding: 0 0 64px;
        }

        /* Bottom two cards centred */
        .nav-grid__row2 {
            grid-column: 1 / -1;
            display: flex;
            justify-content: center;
            gap: 20px;
        }

        .nav-grid__row2 .nav-card {
            width: calc((900px * 0.9 - 40px) / 3);
            max-width: 270px;
        }

        /* ── Nav card ──────────────────────────────────────────── */
        .nav-card {
            position: relative;
            display: flex;
            flex-direction: column;
            align-items: flex-start;
            padding: 28px 28px 24px;
            border: 1px solid var(--brand-border);
            border-radius: 4px;
            background: rgba(30,31,26,0.6);
            backdrop-filter: blur(8px);
            cursor: pointer;
            overflow: hidden;
            transition: border-color 0.3s ease, transform 0.3s ease, box-shadow 0.3s ease;
            text-decoration: none;
        }

        .nav-card::before {
            content: '';
            position: absolute;
            inset: 0;
            background: linear-gradient(135deg, rgba(107,115,85,0.12) 0%, transparent 60%);
            opacity: 0;
            transition: opacity 0.3s ease;
        }

        .nav-card::after {
            content: '';
            position: absolute;
            bottom: 0; left: 0; right: 0;
            height: 2px;
            background: linear-gradient(90deg, var(--brand-olive), var(--brand-gold));
            transform: scaleX(0);
            transform-origin: left;
            transition: transform 0.35s ease;
        }

        .nav-card:hover {
            border-color: var(--brand-olive-light);
            transform: translateY(-4px);
            box-shadow: 0 16px 48px rgba(0,0,0,0.4), 0 0 0 1px rgba(196,168,130,0.1);
        }

        .nav-card:hover::before { opacity: 1; }
        .nav-card:hover::after  { transform: scaleX(1); }

        .nav-card__number {
            font-family: 'Cormorant Garamond', serif;
            font-size: 11px;
            font-weight: 400;
            letter-spacing: 0.18em;
            color: var(--brand-gold);
            margin-bottom: 20px;
            opacity: 0.7;
        }

        .nav-card__icon {
            width: 40px;
            height: 40px;
            margin-bottom: 16px;
            opacity: 0.85;
        }

        .nav-card__icon svg {
            width: 100%;
            height: 100%;
            fill: none;
            stroke: var(--brand-olive-light);
            stroke-width: 1.4;
            stroke-linecap: round;
            stroke-linejoin: round;
            transition: stroke 0.3s ease;
        }

        .nav-card:hover .nav-card__icon svg {
            stroke: var(--brand-gold-light);
        }

        .nav-card__title {
            font-family: 'Cormorant Garamond', serif;
            font-size: 20px;
            font-weight: 500;
            letter-spacing: 0.03em;
            color: var(--brand-cream);
            margin-bottom: 8px;
            line-height: 1.2;
        }

        .nav-card__desc {
            font-size: 12px;
            font-weight: 300;
            letter-spacing: 0.05em;
            color: var(--brand-olive-light);
            line-height: 1.6;
        }

        .nav-card__arrow {
            position: absolute;
            bottom: 22px;
            right: 24px;
            width: 22px;
            height: 22px;
            opacity: 0;
            transform: translateX(-6px);
            transition: opacity 0.3s ease, transform 0.3s ease;
        }

        .nav-card__arrow svg {
            width: 100%;
            height: 100%;
            stroke: var(--brand-gold);
            fill: none;
            stroke-width: 1.5;
            stroke-linecap: round;
            stroke-linejoin: round;
        }

        .nav-card:hover .nav-card__arrow {
            opacity: 1;
            transform: translateX(0);
        }

        /* ── Footer ────────────────────────────────────────────── */
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

        /* ── Page-load animation ───────────────────────────────── */
        @keyframes fadeUp {
            from { opacity: 0; transform: translateY(22px); }
            to   { opacity: 1; transform: translateY(0);    }
        }

        .hero         { animation: fadeUp 0.7s ease both 0.1s; }
        .divider      { animation: fadeUp 0.6s ease both 0.35s; }
        .nav-card:nth-child(1) { animation: fadeUp 0.55s ease both 0.45s; }
        .nav-card:nth-child(2) { animation: fadeUp 0.55s ease both 0.55s; }
        .nav-card:nth-child(3) { animation: fadeUp 0.55s ease both 0.65s; }
        .nav-grid__row2 .nav-card:nth-child(1) { animation: fadeUp 0.55s ease both 0.75s; }
        .nav-grid__row2 .nav-card:nth-child(2) { animation: fadeUp 0.55s ease both 0.85s; }

        /* ── Responsive ────────────────────────────────────────── */
        @media (max-width: 720px) {
            .nav-grid { grid-template-columns: 1fr 1fr; }
            .nav-grid__row2 { flex-direction: column; align-items: center; }
            .nav-grid__row2 .nav-card { width: 100%; max-width: 100%; }
            .top-bar { padding: 0 20px; }
            .footer  { padding: 14px 20px; }
        }

        @media (max-width: 480px) {
            .nav-grid { grid-template-columns: 1fr; }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <div class="page-wrapper">

        <!-- ── Top bar ──────────────────────────────── -->
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

        <!-- ── Hero ─────────────────────────────────── -->
        <section class="hero">
            <p class="hero__eyebrow">Welcome to the Portal</p>

            <div class="hero__logo-container">
                <div class="hero__logo-ring"></div>
                <div class="hero__logo-ring-outer"></div>
                <asp:Image ID="imgLogoHero" runat="server"
                    ImageUrl="~/team_logo.jfif"
                    AlternateText="Zorpz Management Ltd"
                    CssClass="hero__logo-img" />
            </div>

            <h1 class="hero__title">Main <em>Menu</em></h1>
            <p class="hero__subtitle">Select a module to continue</p>
        </section>

        <!-- ── Divider ───────────────────────────────── -->
        <div class="divider">
            <div class="divider__line"></div>
            <div class="divider__diamond"></div>
            <div class="divider__line"></div>
        </div>

        <!-- ── Navigation grid ───────────────────────── -->
        <nav class="nav-grid">

            <!-- Row 1 — 3 cards -->

            <%-- 01 Patients --%>
            <asp:LinkButton ID="btnPatients" runat="server"
                OnClick="btnPatients_Click"
                CssClass="nav-card">
                <span class="nav-card__number">01</span>
                <span class="nav-card__icon">
                    <svg viewBox="0 0 24 24"><path d="M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2"/><circle cx="12" cy="7" r="4"/></svg>
                </span>
                <span class="nav-card__title">Patient Records</span>
                <span class="nav-card__desc">Manage patient profiles, history &amp; clinical notes</span>
                <span class="nav-card__arrow">
                    <svg viewBox="0 0 24 24"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>
                </span>
            </asp:LinkButton>

            <%-- 02 Doctors --%>
            <asp:LinkButton ID="btnDoctors" runat="server"
                OnClick="btnDoctors_Click"
                CssClass="nav-card">
                <span class="nav-card__number">02</span>
                <span class="nav-card__icon">
                    <svg viewBox="0 0 24 24"><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"/><polyline points="9 22 9 12 15 12 15 22"/></svg>
                </span>
                <span class="nav-card__title">Doctor Directory</span>
                <span class="nav-card__desc">View and manage registered physicians &amp; staff</span>
                <span class="nav-card__arrow">
                    <svg viewBox="0 0 24 24"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>
                </span>
            </asp:LinkButton>

            <%-- 03 Medical Records --%>
            <asp:LinkButton ID="btnMedicalRecords" runat="server"
                OnClick="btnMedicalRecords_Click"
                CssClass="nav-card">
                <span class="nav-card__number">03</span>
                <span class="nav-card__icon">
                    <svg viewBox="0 0 24 24"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"/><polyline points="14 2 14 8 20 8"/><line x1="12" y1="18" x2="12" y2="12"/><line x1="9" y1="15" x2="15" y2="15"/></svg>
                </span>
                <span class="nav-card__title">Medical Records</span>
                <span class="nav-card__desc">Access diagnoses, prescriptions &amp; lab results</span>
                <span class="nav-card__arrow">
                    <svg viewBox="0 0 24 24"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>
                </span>
            </asp:LinkButton>

            <!-- Row 2 — 2 cards centred -->
            <div class="nav-grid__row2">

                <%-- 04 Appointments --%>
                <asp:LinkButton ID="btnAppointments" runat="server"
                    OnClick="btnAppointments_Click"
                    CssClass="nav-card">
                    <span class="nav-card__number">04</span>
                    <span class="nav-card__icon">
                        <svg viewBox="0 0 24 24"><rect x="3" y="4" width="18" height="18" rx="2" ry="2"/><line x1="16" y1="2" x2="16" y2="6"/><line x1="8" y1="2" x2="8" y2="6"/><line x1="3" y1="10" x2="21" y2="10"/></svg>
                    </span>
                    <span class="nav-card__title">Appointment Scheduling</span>
                    <span class="nav-card__desc">Book, reschedule &amp; manage patient appointments</span>
                    <span class="nav-card__arrow">
                        <svg viewBox="0 0 24 24"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>
                    </span>
                </asp:LinkButton>

                <%-- 05 Room Booking --%>
                <asp:LinkButton ID="btnRoomBooking" runat="server"
                    OnClick="btnRoomBooking_Click"
                    CssClass="nav-card">
                    <span class="nav-card__number">05</span>
                    <span class="nav-card__icon">
                        <svg viewBox="0 0 24 24"><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"/><path d="M9 22V12h6v10"/><rect x="9" y="4" width="6" height="5" rx="1"/></svg>
                    </span>
                    <span class="nav-card__title">Room Booking</span>
                    <span class="nav-card__desc">Reserve and manage ward rooms &amp; theatre slots</span>
                    <span class="nav-card__arrow">
                        <svg viewBox="0 0 24 24"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>
                    </span>
                </asp:LinkButton>

            </div>
        </nav>

        <!-- ── Footer ───────────────────────────────── -->
        <footer class="footer">
            <span class="footer__copy">&copy; <%= DateTime.Now.Year %> Zorpz Management Ltd. All rights reserved.</span>
            <span class="footer__version">HMS v1.0</span>
        </footer>

    </div>

    </form>
</body>
</html>