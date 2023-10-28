کارهای انجام شده :

1. هرپزشک (که یا عمومی است یا متخصص) میتواند چندین قرار مالقات (ویزیت) داشته باشد.

2. زمان های مجاز قرار ملاقات، شنبه تا چهارشنبه 9 الی 18 است.

3. زمان هر قرار ملاقات پزشک عمومی بین 5 تا 15 دقیقه و پزشک متخصصبین 10 الی 30 دقیقه است.

4. هر پزشک طبق یک برنامه هفتگی در درمانگاه حضور دارد و قرار ملاقات های تنظیم شده با هر پزشک، باید در بازه زمانی حضور پزشک در درمانگاه باشد.

5. قرار ملاقات های یک بیمار نباید با هم همپوشانی داشته باشد.

6. یک بیمار در یک روز، بیش از 2 قرار ملاقات نداشته باشد.

7. حداکثر 2 قرار ملاقات یک پزشک عمومی و 3 قرار ملاقات یک پزشک متخصص میتواند با هم همپوشانی داشته باشد.

ب) توسعه های آتی :


1. در مورد قرار ملاقات خصوصیات دیگر (مثل اتاقویزیت) به سامانه اضافه شود و در تنظیم قرارهالحاظ شود.

2. نوع پزشک دیگر (مانند”فوق تخصص“) هم به سیستم اضافه شود.

3. خبردهی قرار ملاقات به پزشک و بیمار به صورت ایمیل یا پیامک

4. اطلاع رسانی به پزشک و بیمار در صورتی که یک قرار ملاقات تغییر کرد

خروجی :

1. سرویس ثبت یک قرار ملاقات بوسیله کاربردر یک زمان مشخص:

SetAppointment (Doctor, Patient, DurationMinutes, StartDateTime)

2. سرویس ثبت خودکار یک قرار ملاقات در اولین بازه زمانی ممکن برای یک پزشک و یک بیمار:

SetEarliestAppointment (Doctor, Patient, DurationMinutes)

3. سرویس ثبت یک قرار ملاقات بوسیله کاربر در یک زمان مشخص و بدون تعیین طول مدت :


SetEarliestAppointment (Doctor, Patient,StartDateTime)