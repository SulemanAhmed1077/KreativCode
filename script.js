// Glow Cursor Movement Tracking
const cursorGlow = document.getElementById('cursorGlow');

document.addEventListener('mousemove', (e) => {
  cursorGlow.style.left = e.clientX + 'px';
  cursorGlow.style.top = e.clientY + 'px';
});

// Mobile Navigation Toggle
const hamburger = document.getElementById('hamburger');
const navLinks = document.getElementById('navLinks');

hamburger.addEventListener('click', () => {
  navLinks.classList.toggle('active');
  const icon = hamburger.querySelector('i');
  if (navLinks.classList.contains('active')) {
    icon.classList.remove('fa-bars-staggered');
    icon.classList.add('fa-xmark');
  } else {
    icon.classList.remove('fa-xmark');
    icon.classList.add('fa-bars-staggered');
  }
});

// Auto Close Nav on Click (Mobile)
document.querySelectorAll('.nav-links a').forEach(link => {
  link.addEventListener('click', () => {
    navLinks.classList.remove('active');
    const icon = hamburger.querySelector('i');
    icon.classList.remove('fa-xmark');
    icon.classList.add('fa-bars-staggered');
  });
});

// Form Submission Event
const mainForm = document.getElementById('mainForm');
mainForm.addEventListener('submit', (e) => {
  e.preventDefault();
  
  // Custom button feedback
  const btn = mainForm.querySelector('.submit-btn');
  btn.innerHTML = 'Sending... <i class="fa-solid fa-spinner fa-spin"></i>';
  
  setTimeout(() => {
    btn.innerHTML = 'Message Sent! <i class="fa-solid fa-check"></i>';
    btn.style.background = '#10b981';
    
    setTimeout(() => {
      alert('Thank you! KreativCode team will reach out to you within 24 hours.');
      mainForm.reset();
      btn.innerHTML = 'Submit Request <i class="fa-solid fa-paper-plane"></i>';
      btn.style.background = '';
    }, 1000);
  }, 1500);
});