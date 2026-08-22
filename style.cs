/* --- Variables & Cyber Dark Theme --- */
:root {
  --bg-black: #030508;
  --bg-card: rgba(18, 24, 38, 0.6);
  --primary-glow: #7c3aed;
  --secondary-glow: #06b6d4;
  --text-white: #f8fafc;
  --text-muted: #94a3b8;
  --border-glass: rgba(255, 255, 255, 0.08);
  --border-active: rgba(124, 58, 237, 0.5);
}

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Plus Jakarta Sans', sans-serif;
}

html {
  scroll-behavior: smooth;
}

body {
  background-color: var(--bg-black);
  color: var(--text-white);
  overflow-x: hidden;
  position: relative;
}

/* --- Glow Cursor --- */
.cursor-glow {
  position: fixed;
  width: 400px;
  height: 400px;
  background: radial-gradient(circle, rgba(124, 58, 237, 0.15), transparent 70%);
  pointer-events: none;
  transform: translate(-50%, -50%);
  z-index: 9999;
  transition: transform 0.1s ease;
}

/* --- Navbar --- */
.navbar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px 8%;
  background: rgba(3, 5, 8, 0.8);
  backdrop-filter: blur(15px);
  position: fixed;
  width: 100%;
  top: 0;
  z-index: 1000;
  border-bottom: 1px solid var(--border-glass);
}

.logo {
  font-size: 1.6rem;
  font-weight: 800;
  display: flex;
  align-items: center;
  gap: 10px;
}

.logo-icon {
  color: var(--secondary-glow);
}

.accent {
  color: var(--secondary-glow);
}

.nav-links {
  display: flex;
  list-style: none;
  gap: 35px;
}

.nav-links a {
  text-decoration: none;
  color: var(--text-muted);
  font-weight: 600;
  font-size: 0.95rem;
  transition: all 0.3s ease;
}

.nav-links a:hover {
  color: var(--text-white);
  text-shadow: 0 0 10px rgba(255, 255, 255, 0.5);
}

.nav-btn {
  text-decoration: none;
  background: rgba(255, 255, 255, 0.05);
  color: var(--text-white);
  padding: 10px 22px;
  border-radius: 30px;
  border: 1px solid var(--border-glass);
  font-weight: 600;
  font-size: 0.9rem;
  transition: 0.3s ease;
}

.nav-btn:hover {
  border-color: var(--secondary-glow);
  background: rgba(6, 182, 212, 0.1);
}

.hamburger {
  display: none;
  font-size: 1.5rem;
  cursor: pointer;
}

/* --- Hero Section --- */
.hero {
  min-height: 100vh;
  padding: 160px 8% 80px;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
  position: relative;
}

.hero-bg-glow {
  position: absolute;
  top: 20%;
  width: 600px;
  height: 300px;
  background: linear-gradient(45deg, var(--primary-glow), var(--secondary-glow));
  filter: blur(140px);
  opacity: 0.25;
  z-index: -1;
  border-radius: 50%;
}

.badge {
  display: inline-flex;
  align-items: center;
  gap: 8px;
  background: rgba(124, 58, 237, 0.1);
  border: 1px solid rgba(124, 58, 237, 0.3);
  padding: 6px 16px;
  border-radius: 30px;
  font-size: 0.85rem;
  color: #a78bfa;
  margin-bottom: 25px;
}

.badge-dot {
  width: 8px;
  height: 8px;
  background: var(--secondary-glow);
  border-radius: 50%;
  box-shadow: 0 0 10px var(--secondary-glow);
}

.hero h1 {
  font-size: 4rem;
  font-weight: 800;
  line-height: 1.15;
  max-width: 900px;
  margin-bottom: 25px;
}

.text-gradient {
  background: linear-gradient(135deg, #a78bfa, var(--secondary-glow));
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.hero p {
  font-size: 1.15rem;
  color: var(--text-muted);
  max-width: 700px;
  margin-bottom: 40px;
  line-height: 1.7;
}

.hero-actions {
  display: flex;
  gap: 20px;
  margin-bottom: 60px;
}

.btn {
  padding: 14px 32px;
  border-radius: 30px;
  font-weight: 700;
  text-decoration: none;
  display: inline-flex;
  align-items: center;
  gap: 10px;
  transition: all 0.3s ease;
  cursor: pointer;
  border: none;
}

.btn-glow {
  background: linear-gradient(135deg, var(--primary-glow), #6366f1);
  color: white;
  box-shadow: 0 0 25px rgba(124, 58, 237, 0.4);
}

.btn-glow:hover {
  transform: translateY(-3px);
  box-shadow: 0 0 35px rgba(124, 58, 237, 0.7);
}

.btn-glass {
  background: rgba(255, 255, 255, 0.05);
  color: white;
  border: 1px solid var(--border-glass);
}

.btn-glass:hover {
  background: rgba(255, 255, 255, 0.1);
  border-color: var(--text-white);
}

/* Stats Bar */
.hero-stats {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 40px;
  background: var(--bg-card);
  border: 1px solid var(--border-glass);
  padding: 20px 40px;
  border-radius: 20px;
  backdrop-filter: blur(10px);
}

.stat-item h3 {
  font-size: 1.8rem;
  color: var(--secondary-glow);
}

.stat-item p {
  font-size: 0.85rem;
  color: var(--text-muted);
  margin: 0;
}

.stat-divider {
  width: 1px;
  height: 35px;
  background: var(--border-glass);
}

/* --- Services --- */
.services, .portfolio, .contact {
  padding: 100px 8%;
  position: relative;
}

.section-tag {
  color: var(--secondary-glow);
  font-weight: 700;
  font-size: 0.85rem;
  letter-spacing: 2px;
  text-align: center;
  margin-bottom: 10px;
}

.section-title {
  font-size: 2.8rem;
  text-align: center;
  margin-bottom: 15px;
  font-weight: 800;
}

.section-desc {
  text-align: center;
  color: var(--text-muted);
  max-width: 600px;
  margin: 0 auto 60px;
}

.services-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
  gap: 30px;
}

.glow-card {
  background: var(--bg-card);
  border: 1px solid var(--border-glass);
  padding: 40px;
  border-radius: 24px;
  backdrop-filter: blur(10px);
  transition: all 0.4s ease;
  position: relative;
}

.glow-card:hover {
  border-color: var(--border-active);
  transform: translateY(-8px);
  box-shadow: 0 10px 30px rgba(124, 58, 237, 0.15);
}

.featured-card {
  border-color: rgba(6, 182, 212, 0.4);
  background: linear-gradient(180deg, rgba(6, 182, 212, 0.05), var(--bg-card));
}

.popular-badge {
  position: absolute;
  top: -12px;
  right: 25px;
  background: var(--secondary-glow);
  color: black;
  font-size: 0.7rem;
  font-weight: 800;
  padding: 4px 12px;
  border-radius: 12px;
}

.card-icon {
  width: 60px;
  height: 60px;
  background: rgba(124, 58, 237, 0.1);
  border-radius: 16px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 1.6rem;
  color: var(--secondary-glow);
  margin-bottom: 25px;
}

.glow-card h3 {
  font-size: 1.5rem;
  margin-bottom: 15px;
}

.glow-card p {
  color: var(--text-muted);
  line-height: 1.6;
  margin-bottom: 25px;
  font-size: 0.95rem;
}

.service-list {
  list-style: none;
  display: flex;
  flex-direction: column;
  gap: 12px;
}

.service-list li {
  font-size: 0.9rem;
  color: var(--text-white);
  display: flex;
  align-items: center;
  gap: 10px;
}

.service-list i {
  color: var(--secondary-glow);
  font-size: 0.8rem;
}

/* --- Portfolio --- */
.portfolio-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
  gap: 30px;
}

.portfolio-card {
  height: 380px;
  border-radius: 20px;
  overflow: hidden;
  position: relative;
  border: 1px solid var(--border-glass);
}

.portfolio-img {
  width: 100%;
  height: 100%;
  background-size: cover;
  background-position: center;
  transition: transform 0.5s ease;
}

.img-1 { background-image: linear-gradient(to top, rgba(0,0,0,0.8), transparent), url('https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=800&q=80'); }
.img-2 { background-image: linear-gradient(to top, rgba(0,0,0,0.8), transparent), url('https://images.unsplash.com/photo-1600132806370-bf17e65e942f?auto=format&fit=crop&w=800&q=80'); }
.img-3 { background-image: linear-gradient(to top, rgba(0,0,0,0.8), transparent), url('https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&w=800&q=80'); }

.portfolio-card:hover .portfolio-img {
  transform: scale(1.08);
}

.portfolio-overlay {
  position: absolute;
  bottom: 0;
  width: 100%;
  padding: 30px;
  background: linear-gradient(to top, rgba(3, 5, 8, 0.95), transparent);
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
}

.portfolio-overlay span {
  color: var(--secondary-glow);
  font-size: 0.8rem;
  font-weight: 700;
  text-transform: uppercase;
}

.portfolio-overlay h3 {
  font-size: 1.3rem;
  margin-top: 5px;
}

.portfolio-btn {
  position: absolute;
  right: 30px;
  bottom: 30px;
  width: 45px;
  height: 45px;
  background: rgba(255, 255, 255, 0.1);
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  color: white;
  text-decoration: none;
  backdrop-filter: blur(5px);
  transition: 0.3s ease;
}

.portfolio-btn:hover {
  background: var(--secondary-glow);
  color: black;
}

/* --- Contact Section --- */
.contact-wrapper {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 60px;
  background: var(--bg-card);
  padding: 60px;
  border-radius: 30px;
  border: 1px solid var(--border-glass);
}

.contact-info .section-tag {
  text-align: left;
}

.contact-info h2 {
  font-size: 2.5rem;
  margin: 15px 0;
}

.contact-info p {
  color: var(--text-muted);
  line-height: 1.6;
  margin-bottom: 40px;
}

.contact-details {
  display: flex;
  flex-direction: column;
  gap: 25px;
}

.detail-item {
  display: flex;
  align-items: center;
  gap: 20px;
}

.detail-item i {
  width: 50px;
  height: 50px;
  background: rgba(124, 58, 237, 0.15);
  border-radius: 12px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--secondary-glow);
  font-size: 1.2rem;
}

.contact-form {
  display: flex;
  flex-direction: column;
  gap: 20px;
}

.contact-form h3 {
  font-size: 1.5rem;
  margin-bottom: 10px;
}

.input-box input,
.input-box select,
.input-box textarea {
  width: 100%;
  padding: 16px 20px;
  background: rgba(3, 5, 8, 0.6);
  border: 1px solid var(--border-glass);
  border-radius: 14px;
  color: white;
  outline: none;
  font-size: 0.95rem;
  transition: 0.3s;
}

.input-box input:focus,
.input-box select:focus,
.input-box textarea:focus {
  border-color: var(--secondary-glow);
  box-shadow: 0 0 15px rgba(6, 182, 212, 0.2);
}

.submit-btn {
  justify-content: center;
  width: 100%;
  padding: 16px;
}

/* --- Footer --- */
footer {
  padding: 60px 8% 30px;
  border-top: 1px solid var(--border-glass);
  text-align: center;
}

.footer-content p {
  color: var(--text-muted);
  margin: 15px 0 25px;
}

.socials {
  display: flex;
  justify-content: center;
  gap: 20px;
  margin-bottom: 40px;
}

.socials a {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  border: 1px solid var(--border-glass);
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--text-white);
  text-decoration: none;
  transition: 0.3s ease;
}

.socials a:hover {
  background: var(--secondary-glow);
  color: black;
  border-color: var(--secondary-glow);
}

.footer-bottom {
  color: var(--text-muted);
  font-size: 0.85rem;
  border-top: 1px solid rgba(255, 255, 255, 0.03);
  padding-top: 25px;
}

/* --- Mobile Responsiveness --- */
@media (max-width: 992px) {
  .hero h1 { font-size: 3rem; }
  .contact-wrapper { grid-template-columns: 1fr; padding: 40px; }
  .hero-stats { flex-direction: column; gap: 20px; }
  .stat-divider { width: 100%; height: 1px; }
}

@media (max-width: 768px) {
  .hamburger { display: block; color: var(--text-white); }
  .nav-btn { display: none; }
  .nav-links {
    position: fixed;
    top: 70px;
    right: -100%;
    width: 100%;
    height: 100vh;
    background: var(--bg-black);
    flex-direction: column;
    align-items: center;
    padding-top: 60px;
    transition: 0.4s ease;
  }
  .nav-links.active { right: 0; }
  .hero h1 { font-size: 2.3rem; }
  .hero-actions { flex-direction: column; width: 100%; }
  .btn { width: 100%; justify-content: center; }
}