:root {
  --primary-color: #ff4e50;
  --bg-gradient: linear-gradient(135deg, #ff758c 0%, #ff7eb3 100%);
  --card-bg: rgba(255, 255, 255, 0.9);
}

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  font-family: system-ui, -apple-system, sans-serif;
  background: var(--bg-gradient);
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  overflow-x: hidden;
  position: relative;
}

.heart-bg {
  position: absolute;
  top: -10%;
  color: rgba(255, 255, 255, 0.6);
  animation: floatUp 8s linear infinite;
  user-select: none;
  z-index: 1;
}

@keyframes floatUp {
  0% { transform: translateY(0) rotate(0deg); opacity: 1; }
  100% { transform: translateY(-110vh) rotate(360deg); opacity: 0; }
}

.card {
  background: var(--card-bg);
  backdrop-filter: blur(10px);
  padding: 2.5rem 2rem;
  border-radius: 20px;
  box-shadow: 0 15px 35px rgba(0, 0, 0, 0.15);
  text-align: center;
  max-width: 450px;
  width: 90%;
  z-index: 10;
  animation: scaleIn 0.8s ease-out;
}

@keyframes scaleIn {
  from { transform: scale(0.8); opacity: 0; }
  to { transform: scale(1); opacity: 1; }
}

.card h1 {
  color: #d63384;
  font-size: 2rem;
  margin-bottom: 0.5rem;
}

.subtitle {
  color: #666;
  font-size: 0.95rem;
  margin-bottom: 1.5rem;
}

.message {
  color: #444;
  font-size: 1.05rem;
  line-height: 1.6;
  margin-bottom: 2rem;
}

.btn {
  background: linear-gradient(45deg, #ff4e50, #f9d423);
  color: white;
  border: none;
  padding: 0.8rem 1.8rem;
  font-size: 1rem;
  font-weight: bold;
  border-radius: 50px;
  cursor: pointer;
  box-shadow: 0 5px 15px rgba(255, 78, 80, 0.4);
  transition: all 0.3s ease;
}

.btn:hover {
  transform: translateY(-3px) scale(1.05);
}

.secret-wish {
  display: none;
  margin-top: 1.5rem;
  padding: 1rem;
  background: #fff0f3;
  border-radius: 12px;
  border: 1px dashed #ff4e50;
  color: #c9184a;
  font-weight: 500;
  animation: fadeIn 0.5s ease-in;
}

@keyframes fadeIn {
  from { opacity: 0; transform: translateY(10px); }
  to { opacity: 1; transform: translateY(0); }
}
