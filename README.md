# 👔 KariaDapperProject - AI Destekli Moda & Giyim Platformu

![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen)
![Platform](https://img.shields.io/badge/Platform-.NET%209-blue)
![License](https://img.shields.io/badge/License-MIT-orange)

Bu proje, **.NET 9** altyapısı kullanılarak geliştirilmiş, performans odaklı bir web uygulamasıdır. Klasik e-ticaret/blog yapısının ötesine geçerek, **Google Gemini AI** entegrasyonu sayesinde kullanıcılara kişiselleştirilmiş giyim ve kombin tavsiyeleri sunar.

## 🚀 Proje Hakkında

Bu proje, modern web mimarileri ve yapay zeka servislerinin entegrasyonunu deneyimlemek amacıyla geliştirilmiştir. Veri tabanı işlemlerinde hız ve kontrol sağlamak adına Micro-ORM mimarisi tercih edilmiştir.

### Öne Çıkan Özellikler

* **🤖 Google Gemini AI Entegrasyonu:** Kullanıcılar, yapay zekaya sorular sorarak (Örn: "Mavi gömlek altına ne giyilir?") anlık stil önerileri alabilirler.
* **⚡ Dapper ORM:** Veri tabanı işlemleri (CRUD) Dapper kullanılarak, ham SQL sorguları ile yüksek performansta gerçekleştirilir.
* **🏗️ Modüler Mimari (Areas):** Admin ve Kullanıcı (UI) arayüzleri `Areas` yapısı ile birbirinden izole edilerek daha yönetilebilir bir yapı kurulmuştur.
* **🧩 ViewComponents:** Tekrar eden arayüz bileşenleri (Menüler, Sidebar, Öne Çıkanlar vb.) `ViewComponent` kullanılarak dinamik hale getirilmiştir.
* **🔐 Admin Paneli:** Ürün ve içerik yönetimi için tam kapsamlı CRUD işlemleri.

## 🛠️ Teknolojiler

* **Backend:** ASP.NET Core (.NET 9)
* **Veri Tabanı Erişimi:** Dapper (Micro-ORM)
* **AI Servisi:** Google Gemini API
* **Frontend:** HTML5, CSS3, Bootstrap 5, Razor Pages
