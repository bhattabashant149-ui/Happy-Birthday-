document.addEventListener('DOMContentLoaded', () => {
  createHearts();
  const button = document.getElementById('surpriseBtn');
  button.addEventListener('click', celebrate);
});

function createHearts() {
  const container = document.getElementById('heartContainer');
  for (let i = 0; i < 15; i++) {
    const heart = document.createElement('div');
    heart.classList.add('heart-bg');
    heart.innerHTML = '❤️';
    heart.style.left = Math.random() * 100 + 'vw';
    heart.style.top = Math.random() * 100 + 'vh';
    heart.style.fontSize = (Math.random() * 20 + 15) + 'px';
    heart.style.animationDuration = (Math.random() * 5 + 5) + 's';
    heart.style.animationDelay = (Math.random() * 5) + 's';
    container.appendChild(heart);
  }
}

function celebrate() {
  const secret = document.getElementById('secretWish');
  secret.style.display = 'block';

  confetti({
    particleCount: 100,
    spread: 70,
    origin: { y: 0.6 }
  });

  setTimeout(() => {
    confetti({ particleCount: 50, angle: 60, spread: 55, origin: { x: 0 } });
    confetti({ particleCount: 50, angle: 120, spread: 55, origin: { x: 1 } });
  }, 250);
}
