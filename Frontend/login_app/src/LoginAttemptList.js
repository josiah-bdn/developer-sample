import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = ({ login, timestamp }) => (
  <li>
    {login} logged in at {timestamp}
  </li>
);

const LoginAttemptList = ({ attempts }) => (
  <div className="Attempt-List-Main">
    <p>Recent activity</p>
    <input type="input" placeholder="Filter..." />
    <ul className="Attempt-List">
      {attempts.map((attempt, index) => (
        <LoginAttempt
          key={index}
          login={attempt.login}
          timestamp={attempt.timestamp}
        />
      ))}
    </ul>
  </div>
);

export default LoginAttemptList;
