@charset "UTF-8";
h1 {
  font-family: "Shrikhand", Helvetica sans-serif;
}

body {
  font-family: "Roboto", Helvetica, sans-serif;
}

.loading__bar {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 2rem;
  border: 15px solid;
  border-radius: 50%;
  width: 100px;
  height: 100px;
  border-top-color: lightcoral;
  border-bottom-color: rebeccapurple;
  animation: spinner 3s cubic-bezier(0.85, -0.19, 0.39, 1.14) 0.1ms alternate both running;
}
.loading__title {
  animation: logo-skew 1.7s 2s ease-in-out both;
  font-family: "Shrikhand", Helvetica sans-serif;
  font-size: 3em;
  background: -webkit-linear-gradient(#9356DC, #FF79DA);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.menuItem {
  padding: 1rem;
  margin: 10px 1rem 2rem 1rem;
  cursor: pointer;
  display: flex;
  background-color: #f4f4f4;
  box-shadow: 0px 5px 10px 0px rgba(194, 194, 194, 0.78);
  justify-content: space-between;
  animation: anim-menu 1.1s ease-in-out;
  background-color: #fafafa;
  border-radius: 15px;
  margin: 0;
  margin-bottom: 1rem;
  width: 100%;
  padding: 1rem 1rem 10px 1rem;
}
.menuItem--1 {
  animation-delay: 80ms;
}
.menuItem--2 {
  animation-delay: 160ms;
}
.menuItem--3 {
  animation-delay: 240ms;
}
.menuItem--4 {
  animation-delay: 320ms;
}
.menuItem--5 {
  animation-delay: 400ms;
}
.menuItem--6 {
  animation-delay: 480ms;
}
.menuItem--7 {
  animation-delay: 560ms;
}
.menuItem--8 {
  animation-delay: 640ms;
}
.menuItem--9 {
  animation-delay: 720ms;
}
.menuItem__dishname {
  font-size: 1.1em;
  font-weight: 600;
  margin-bottom: 5px;
}
.menuItem__dishname p {
  font-weight: normal;
  text-overflow: ellipsis;
}
.menuItem__price {
  display: flex;
  justify-content: space-between;
  align-items: center;
  font-weight: 700;
}
.menuItem__checkcircle {
  border-radius: 0 15px 15px 0;
  position: relative;
  overflow: hidden;
  width: 0px;
  height: 70px;
  background-color: #fafafa;
}
.menuItem:hover .menuItem__checkcircle > .menuItem__icon {
  right: 0;
  transition: 0.6s ease-in-out;
}
.menuItem__icon {
  display: flex;
  justify-content: center;
  align-items: center;
  position: absolute;
  right: -100px;
  width: 100px;
  height: 70px;
  background-color: #99E2D0;
  color: #ffff;
  font-size: 1.4rem;
  transition: 0.5s ease-in-out;
}
.menuItem:hover .fa-check-circle {
  transform: rotate(360deg);
  transition: 1s;
}

/*

&:hover > &__checkcircle {
        right: 0;
        transition: 1s ease-in-out;  
    }

&:hover {
    & > .menu__checkcircle {
        @include flex-center;
        width: 0%;
        position: relative;
        overflow: hidden;
        padding: 1rem;
        border-radius: $radius-check-bloc;
        background-color: map-get($colours, "accent-colour");
        animation: anim-slidex $duration $method $delay both;
        & > .fa-check-circle {
                position: absolute;
                background-color: map-get($colours, "accent-colour");
                color: #ffff;
                font-size: 1.4rem;    
                animation: anim-rotate-circle $duration $method $delay both;
                .fa-check-circle::before {
                    content: "";
                    display: none;
                }
        }   
    }
}

*/
@keyframes anim-rotate-circle {
  0% {
    transform: rotate(0deg) scale(1);
  }
  100% {
    transform: rotate(360deg) scale(1.2);
  }
}
@keyframes anim-menu {
  0% {
    transform: translateY(-1000px) scale(0.1);
    opacity: 0.1;
  }
  50% {
    transform: scale(0.5);
    opacity: 0.3;
  }
  100% {
    transform: translateY(0px) scale(1);
    opacity: 1;
  }
}
@keyframes anim-menu-desktop {
  0% {
    transform: translate(-2000px);
    opacity: 0;
  }
  100% {
    transform: translate(0px);
    opacity: 1;
  }
}
@keyframes loader {
  0% {
    transform: opacity 1;
  }
  100% {
    opacity: 0;
  }
}
@keyframes spinner {
  0% {
    transform: rotate(0deg);
    opacity: 1;
  }
  50% {
    transform: rotate(360deg) scale(1.2);
  }
  75% {
    transform: rotate(720deg) scale(1.1);
    opacity: 0.8;
  }
  100% {
    transform: rotate(1440deg) scale(0);
    opacity: 0.4;
  }
}
@keyframes logo-skew {
  0% {
    transform: skewX(0.5turn) scale(1);
    opacity: 1;
  }
  70% {
    transform: skewX(1turn) scale(1.2);
    opacity: 0.7;
  }
  100% {
    transform: skewX(1turn) scale(1);
    opacity: 0;
  }
}
.header__logo {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 1rem;
}
.header__title {
  font-size: 2em;
  text-shadow: 0 0 black;
}

.form-location {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #e7e7e7;
  box-shadow: 0px -1px 1px 0px rgba(194, 194, 194, 0.78);
  text-align: center;
  padding: 10px;
}
.form-location__icon {
  margin-right: 1rem;
}
.form-location .field {
  text-align: center;
}
.form-location input {
  font-weight: 500;
  background-color: inherit;
  border: none;
}

.proj-explore {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
  padding: 2rem;
  background-color: #f4f4f4;
}
.proj-explore__title {
  font-family: "Roboto", sans-serif;
  font-size: 1.5em;
  font-weight: 800;
}
.proj-explore__par {
  font-weight: 400;
}
.proj-explore__btn {
  padding: 1rem;
  background: linear-gradient(to top, #9356DC, #FF79DA);
  color: #f5f5f5;
  font-weight: 600;
  border: none;
  border-radius: 50px;
  box-shadow: 0px 5px 10px 0px rgba(194, 194, 194, 0.78);
}
.proj-explore__btn:hover {
  box-shadow: 0px -1px 1px 0px rgba(194, 194, 194, 0.78);
  opacity: 0.93;
}

.proj-function {
  /*display: flex;
  flex-direction: row; */
}
.proj-function__header {
  font-family: "Roboto", sans-serif;
  font-size: 1.5em;
  font-weight: 800;
}
@media screen and (min-width: 375px) {
  .proj-function__list {
    flex-direction: column;
    flex-wrap: wrap;
    text-align: center;
  }
}
@media screen and (min-width: 1024px) {
  .proj-function__list {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
  }
}
.proj-function__btn {
  padding: 1rem;
  margin: 10px 1rem 2rem 1rem;
  cursor: pointer;
  display: flex;
  background-color: #f4f4f4;
  box-shadow: 0px 5px 10px 0px rgba(194, 194, 194, 0.78);
  border-radius: 15px;
}
@media screen and (min-width: 1024px) {
  .proj-function__btn {
    width: 23%;
    padding: 10px 15px;
  }
}
.proj-function__btn:hover {
  background-color: #e4d5f6;
  box-shadow: 0px -1px 1px 0px rgba(194, 194, 194, 0.78);
}
.proj-function__circle {
  position: absolute;
  background-color: #9356DC;
  color: #f5f5f5;
  height: 26px;
  width: 26px;
  border-radius: 50%;
  padding: 5px;
  left: 0;
}
@media screen and (min-width: 1024px) {
  .proj-function__circle {
    position: relative;
    left: -30px;
    top: 1px;
  }
}
.proj-function__icon {
  margin-right: 10px;
  color: #939393;
}
@media screen and (min-width: 1024px) {
  .proj-function__icon {
    margin-top: 5px;
    margin-right: 5px;
  }
}
@media screen and (min-width: 1024px) {
  .proj-function__title {
    margin-top: 5px;
  }
}

.restaurant {
  margin: 0;
  padding: 0;
  margin: auto;
  width: 100%;
  padding: 2rem;
  background-color: #f4f4f4;
}
@media screen and (min-width: 375px) {
  .restaurant {
    display: flex;
    flex-direction: column;
  }
}
@media screen and (min-width: 1024px) {
  .restaurant {
    display: flex;
    flex-direction: row;
    justify-content: space-around;
  }
}
.restaurant__title {
  font-family: "Roboto", sans-serif;
  font-size: 1.5em;
  font-weight: 800;
  background-color: #f4f4f4;
}
.restaurant .restaurant__panel {
  position: relative;
  margin: 1rem;
  box-shadow: 0px 5px 10px 0px rgba(194, 194, 194, 0.78);
  border-radius: 15px;
  overflow: hidden;
  background-color: #f5f5f5;
}
@media screen and (min-width: 375px) {
  .restaurant .restaurant__panel {
    width: 90vw;
    max-width: unset;
  }
}
.restaurant .restaurant__panel:hover {
  transform: translateY(10px);
  transition: all 0.4s ease-in-out;
}
.restaurant__img {
  display: block;
  width: 100%;
  object-fit: cover;
  overflow: hidden;
  border-radius: 20px 20px 0px 0px;
}
@media screen and (min-width: 375px) {
  .restaurant__img {
    height: 175px;
  }
}
@media screen and (min-width: 1024px) {
  .restaurant__img {
    height: 300px;
  }
}
.restaurant .new {
  display: inline-block;
  position: absolute;
  right: 20px;
  top: 15px;
  padding: 10px;
  border-radius: 2px;
  background: #99E2D0;
  color: #278870;
  font-weight: 500;
}

.restaurant__content {
  padding: 10px 10px 5px 10px;
  display: flex;
  flex-direction: column;
}
.restaurant__content .boldtitle {
  font-weight: 700;
  margin-bottom: 5px;
}

.restaurant__heart {
  position: absolute;
  align-self: flex-end;
}
.restaurant__heart .fa-heart {
  font-size: 1.4em;
  background-color: #f3ec78;
  background-image: linear-gradient(45deg, #f3ec78, #af4261);
  background-size: 100%;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.restaurant__heart .fa-heart:hover {
  animation: anim-rotate-circle 0.7s ease-in-out 0.3ms both;
  background: -webkit-linear-gradient(#9356DC, #FF79DA);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.restaurant__heart .fa-heart:hover::before {
  transition: all 1s ease-in-out;
  -webkit-background-clip: text;
  font-weight: 900;
  background-image: linear-gradient(#9356DC, #FF79DA);
  -webkit-text-fill-color: transparent;
}

.footer {
  background-color: #1a1919;
  padding: 1rem;
}
@media screen and (min-width: 1024px) {
  .footer {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: space-between;
    padding: 50px;
  }
}
.footer__logo {
  color: #f5f5f5;
  font-family: "Shrikhand", sans-serif;
  margin-bottom: 1rem;
}
.footer__title {
  color: #f5f5f5;
  font-size: 1.4em;
}
.footer__content {
  color: #f5f5f5;
  font-size: 1.1em;
}
.footer__icon {
  margin-top: 1rem;
}
.footer__icon .fas {
  font-size: 1.3em;
}
.footer__par {
  margin-top: 1rem;
}
.footer__item {
  display: flex;
  flex-direction: column;
}
.footer__link {
  margin-top: 1rem;
}

/* Apparition des btn avec opacity et arrivée des btn avec translateY() -10000px

/* transition rotation de 360° du checkcircle rotate(360) et div parente translate(x,y), balise P rogné avec text overflow ellipsis au click*/
@media screen and (min-width: 375px) {
  .restaurant-header {
    color: rebeccapurple;
  }
}
.restaurant-header__logo {
  padding: 1rem;
}
.restaurant-header__arrow {
  display: inline-block;
  position: absolute;
  top: 20px;
}
.restaurant-header__background {
  display: block;
  width: 100%;
  object-fit: cover;
  overflow: hidden;
  border-radius: 20px 20px 0px 0px;
  border-radius: 0;
  height: 300px;
  position: relative;
  left: 0px;
  top: 0px;
  z-index: -1;
}
.restaurant-header__title {
  font-size: 2em;
  text-shadow: 0 0 black;
  display: flex;
  justify-content: center;
}

.container .menu {
  animation: anim-menu 1s ease-in-out;
  background-color: #f4f4f4;
  border-radius: 40px 40px 0 0;
  margin-top: -40px;
  z-index: 999;
  margin-right: 1rem;
  padding: 2rem;
  width: 100%;
}
.container .menu .menu-header {
  display: flex;
  justify-content: space-between;
  margin-bottom: 2rem;
}
.container .menu .menu-header__title {
  font-size: 2em;
  text-shadow: 0 0 black;
}
.container .menu .far {
  font-size: 1.4em;
}
@media screen and (min-width: 1024px) {
  .container .menu .btns-container {
    animation: anim-menu-desktop 1.1s ease-in-out;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
  }
}
.container .menu__name {
  text-transform: uppercase;
  border-bottom: 3px solid #99E2D0;
  padding-bottom: 5px;
  width: 40px;
  margin-bottom: 1rem;
}
.container .order {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #f4f4f4;
  padding: 2rem 0 4rem 0;
}
.container .order__btn {
  padding: 1rem;
  background: linear-gradient(to top, #9356DC, #FF79DA);
  color: #f5f5f5;
  font-weight: 600;
  border: none;
  border-radius: 50px;
  box-shadow: 0px 5px 10px 0px rgba(194, 194, 194, 0.78);
  width: 200px;
}
.container .order__btn:hover {
  box-shadow: 0px -1px 1px 0px rgba(194, 194, 194, 0.78);
  opacity: 0.93;
}

/*# sourceMappingURL=cs.map */
