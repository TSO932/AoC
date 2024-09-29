namespace _2023

module Day19Part1 =

    let mutable accepted = 0
    let mutable rejected = 0

    let A(x:int, m:int, a:int, s:int) = accepted <- accepted + (x + m + a + s)
    let R(x:int, m:int, a:int, s:int) = rejected <- rejected + 1

    let ReR = R
    let AeA = A
    

    let pv(x:int, m:int, a:int, s:int)  = if a>1716 then R(x,m,a,s) else A(x,m,a,s)
    let lnx(x:int, m:int, a:int, s:int)  = if m>1548 then A(x,m,a,s) else AeA(x,m,a,s)

    let qs0(x:int, m:int, a:int, s:int)  = if s>3448 then A(x,m,a,s) else lnx(x,m,a,s)

    let crn(x:int, m:int, a:int, s:int)  = if x>2662 then A(x,m,a,s) else R(x,m,a,s)


    let gd(x:int, m:int, a:int, s:int)  = if a>3333 then R(x,m,a,s) else ReR(x,m,a,s)
    let hdj(x:int, m:int, a:int, s:int)  = if m>838 then A(x,m,a,s) else pv(x,m,a,s)

    let rfg(x:int, m:int, a:int, s:int)  = if s<537 then gd(x,m,a,s) elif x>2440 then R(x,m,a,s) else A(x,m,a,s)
    let qkq(x:int, m:int, a:int, s:int)  = if x<1416 then A(x,m,a,s) else crn(x,m,a,s)

    let qqz(x:int, m:int, a:int, s:int)  = if s>2770 then qs0(x,m,a,s) elif m<1801 then hdj(x,m,a,s) else R(x,m,a,s)
    let px0(x:int, m:int, a:int, s:int)  = if a<2006 then qkq(x,m,a,s) elif m>2090 then A(x,m,a,s) else rfg(x,m,a,s)


    let in1(x:int, m:int, a:int, s:int)  = if s<1351 then px0(x,m,a,s) else qqz(x,m,a,s)





    let mn(x:int, m:int, a:int, s:int)  = if s<3661 then A(x,m,a,s) elif s>3705 then A(x,m,a,s) elif m<1698 then R(x,m,a,s) else A(x,m,a,s)
    let jcj(x:int, m:int, a:int, s:int)  = if x<2501 then R(x,m,a,s) elif s<516 then R(x,m,a,s) else A(x,m,a,s)
    let lm(x:int, m:int, a:int, s:int)  = if s>1017 then R(x,m,a,s) elif a>470 then R(x,m,a,s) elif x>159 then A(x,m,a,s) else R(x,m,a,s)


    let xd(x:int, m:int, a:int, s:int)  = if a<3515 then A(x,m,a,s) elif x<1086 then R(x,m,a,s) else ReR(x,m,a,s)


    let gz(x:int, m:int, a:int, s:int)  = if x<1839 then R(x,m,a,s) elif x>1848 then A(x,m,a,s) else R(x,m,a,s)
    let lc(x:int, m:int, a:int, s:int)  = if m<2328 then A(x,m,a,s) elif x>3513 then A(x,m,a,s) else R(x,m,a,s)
    let qc(x:int, m:int, a:int, s:int)  = if x<1673 then A(x,m,a,s) else AeA(x,m,a,s)


    let jlj(x:int, m:int, a:int, s:int)  = if a>2672 then A(x,m,a,s) else R(x,m,a,s)


    let zz(x:int, m:int, a:int, s:int)  = if m<2544 then R(x,m,a,s) elif a<2964 then A(x,m,a,s) elif s<1093 then R(x,m,a,s) else A(x,m,a,s)
    let jbv(x:int, m:int, a:int, s:int)  = if a>1587 then A(x,m,a,s) elif m>698 then R(x,m,a,s) elif s<2324 then R(x,m,a,s) else A(x,m,a,s)
    let kqc(x:int, m:int, a:int, s:int)  = if a>1656 then A(x,m,a,s) elif x<181 then R(x,m,a,s) elif a<1532 then R(x,m,a,s) else jbv(x,m,a,s)
    let lrh(x:int, m:int, a:int, s:int)  = if x<1401 then A(x,m,a,s) elif a>789 then R(x,m,a,s) else A(x,m,a,s)


    let gp(x:int, m:int, a:int, s:int)  = if x>1091 then A(x,m,a,s) elif m>2260 then A(x,m,a,s) else R(x,m,a,s)
    let xnx(x:int, m:int, a:int, s:int)  = if s>1313 then R(x,m,a,s) else ReR(x,m,a,s)
    let nhv(x:int, m:int, a:int, s:int)  = if s>2972 then A(x,m,a,s) else AeA(x,m,a,s)

    let bmj(x:int, m:int, a:int, s:int)  = if m<1925 then R(x,m,a,s) elif a>1048 then A(x,m,a,s) else R(x,m,a,s)
    let rm(x:int, m:int, a:int, s:int)  = if s>1123 then A(x,m,a,s) else AeA(x,m,a,s)

    let qn(x:int, m:int, a:int, s:int)  = if m<1271 then A(x,m,a,s) else AeA(x,m,a,s)
    let tgj(x:int, m:int, a:int, s:int)  = if a<1770 then R(x,m,a,s) else A(x,m,a,s)
    let mj(x:int, m:int, a:int, s:int)  = if s<2970 then R(x,m,a,s) elif x<1353 then A(x,m,a,s) else AeA(x,m,a,s)
    let cd(x:int, m:int, a:int, s:int)  = if a<1640 then A(x,m,a,s)  elif s<2718 then A(x,m,a,s) else AeA(x,m,a,s)
    let xmv(x:int, m:int, a:int, s:int)  = if a>3790 then A(x,m,a,s)  elif x<1023 then R(x,m,a,s) else A(x,m,a,s)
    let ksl(x:int, m:int, a:int, s:int)  = if x>1716 then A(x,m,a,s) else R(x,m,a,s)
    let nsp(x:int, m:int, a:int, s:int)  = if x<355 then R(x,m,a,s) else A(x,m,a,s)
    let fck(x:int, m:int, a:int, s:int)  = if s>2679 then A(x,m,a,s) else AeA(x,m,a,s)

    let gm(x:int, m:int, a:int, s:int)  = if x<546 then R(x,m,a,s) elif s>3053 then A(x,m,a,s) elif a>3376 then A(x,m,a,s) else AeA(x,m,a,s)

    let dsf(x:int, m:int, a:int, s:int)  = if m>720 then A(x,m,a,s) else AeA(x,m,a,s)
    let gkk(x:int, m:int, a:int, s:int)  = if s<2039 then R(x,m,a,s) elif a>94 then R(x,m,a,s) else ReR(x,m,a,s)

    let mrc(x:int, m:int, a:int, s:int)  = if a>3426 then A(x,m,a,s) else R(x,m,a,s)
    let zms(x:int, m:int, a:int, s:int)  = if a>3329 then A(x,m,a,s) else R(x,m,a,s)
    let kdb(x:int, m:int, a:int, s:int)  = if s<3016 then R(x,m,a,s) else A(x,m,a,s)
    let gph(x:int, m:int, a:int, s:int)  = if x<123 then A(x,m,a,s) else R(x,m,a,s)
    let ms(x:int, m:int, a:int, s:int)  = if x<3198 then R(x,m,a,s) else A(x,m,a,s)
    let ph(x:int, m:int, a:int, s:int)  = if m<1356 then R(x,m,a,s) else ReR(x,m,a,s)

    let zr(x:int, m:int, a:int, s:int)  = if x>1726 then A(x,m,a,s) else R(x,m,a,s)
    let skj(x:int, m:int, a:int, s:int)  = if x<80 then A(x,m,a,s) else R(x,m,a,s)
    let hsz(x:int, m:int, a:int, s:int)  = if a>1328 then R(x,m,a,s) else A(x,m,a,s)

    let lvs(x:int, m:int, a:int, s:int)  = if x>1273 then A(x,m,a,s) else R(x,m,a,s)
    let qdf(x:int, m:int, a:int, s:int)  = if s<1591 then R(x,m,a,s) elif a<256 then A(x,m,a,s) else lvs(x,m,a,s)
    let jp(x:int, m:int, a:int, s:int)  = if a<325 then R(x,m,a,s) elif a>333 then R(x,m,a,s) elif a>330 then A(x,m,a,s) else R(x,m,a,s)
    let ktt(x:int, m:int, a:int, s:int)  = if a>231 then R(x,m,a,s) else ReR(x,m,a,s)
    let kkt(x:int, m:int, a:int, s:int)  = if a>3472 then A(x,m,a,s) elif a>3382 then A(x,m,a,s) elif s>2345 then A(x,m,a,s) else AeA(x,m,a,s)

    let tr(x:int, m:int, a:int, s:int)  = if s<3868 then A(x,m,a,s) elif x>1733 then R(x,m,a,s) elif s>3944 then A(x,m,a,s) else R(x,m,a,s)
    let xv(x:int, m:int, a:int, s:int)  = if a>3190 then R(x,m,a,s) else A(x,m,a,s)
    let hgr(x:int, m:int, a:int, s:int)  = if m<3265 then A(x,m,a,s) elif m<3624 then A(x,m,a,s) elif m<3842 then R(x,m,a,s) else A(x,m,a,s)
    let hk(x:int, m:int, a:int, s:int)  = if a>3745 then A(x,m,a,s) elif x>1782 then R(x,m,a,s) elif x>1749 then R(x,m,a,s) else A(x,m,a,s)
    let gst(x:int, m:int, a:int, s:int)  = if x<1764 then A(x,m,a,s) elif s<2078 then R(x,m,a,s) elif s<2479 then R(x,m,a,s) else A(x,m,a,s)
    let fmp(x:int, m:int, a:int, s:int)  = if a<637 then R(x,m,a,s) elif m>2055 then R(x,m,a,s) else ReR(x,m,a,s)
    let cl(x:int, m:int, a:int, s:int)  = if x>327 then R(x,m,a,s) elif a<662 then R(x,m,a,s) else A(x,m,a,s)
    let jg(x:int, m:int, a:int, s:int)  = if a>3308 then A(x,m,a,s) elif a>3257 then R(x,m,a,s) elif a<3243 then A(x,m,a,s) else R(x,m,a,s)
    let vm(x:int, m:int, a:int, s:int)  = if x>1608 then A(x,m,a,s) elif s>2267 then R(x,m,a,s) else ReR(x,m,a,s)
    let pg(x:int, m:int, a:int, s:int)  = if x>2454 then R(x,m,a,s) elif a<3237 then A(x,m,a,s) else AeA(x,m,a,s)
    let jt(x:int, m:int, a:int, s:int)  = if a<2036 then A(x,m,a,s) elif x>3568 then R(x,m,a,s) else ReR(x,m,a,s)
    let rkx(x:int, m:int, a:int, s:int)  = if a<3478 then R(x,m,a,s) elif x>1142 then A(x,m,a,s) elif a>3606 then R(x,m,a,s) else A(x,m,a,s)
    let mk(x:int, m:int, a:int, s:int)  = if x<204 then R(x,m,a,s) else A(x,m,a,s)
    let mt(x:int, m:int, a:int, s:int)  = if a<512 then R(x,m,a,s) elif a>675 then R(x,m,a,s) elif a<618 then R(x,m,a,s) else A(x,m,a,s)
    let cbq(x:int, m:int, a:int, s:int)  = if a<3691 then R(x,m,a,s) else ReR(x,m,a,s)
    let zvk(x:int, m:int, a:int, s:int)  = if s>3078 then R(x,m,a,s) elif s>2987 then R(x,m,a,s) elif a>3465 then A(x,m,a,s) else R(x,m,a,s)
    let cgg(x:int, m:int, a:int, s:int)  = if s>166 then A(x,m,a,s) else R(x,m,a,s)
    let qtf(x:int, m:int, a:int, s:int)  = if a<798 then A(x,m,a,s) else R(x,m,a,s)
    let vtk(x:int, m:int, a:int, s:int)  = if a<3490 then A(x,m,a,s) else R(x,m,a,s)


    let gh(x:int, m:int, a:int, s:int)  = if x>1717 then A(x,m,a,s) elif a>3671 then A(x,m,a,s) elif s>547 then A(x,m,a,s) else AeA(x,m,a,s)
    let dxt(x:int, m:int, a:int, s:int)  = if m<2555 then R(x,m,a,s) else A(x,m,a,s)
    let dzn(x:int, m:int, a:int, s:int)  = if x>2899 then A(x,m,a,s) elif a>1917 then A(x,m,a,s) else R(x,m,a,s)
    let cnk(x:int, m:int, a:int, s:int)  = if x<1638 then R(x,m,a,s) elif s<2322 then A(x,m,a,s) elif x<1784 then A(x,m,a,s) else AeA(x,m,a,s)
    let rdg(x:int, m:int, a:int, s:int)  = if x>1665 then R(x,m,a,s) elif x<1662 then R(x,m,a,s) else ReR(x,m,a,s)
    let xkp(x:int, m:int, a:int, s:int)  = if x<1813 then R(x,m,a,s) elif a<3429 then A(x,m,a,s) else AeA(x,m,a,s)
    let vgj(x:int, m:int, a:int, s:int)  = if x<3716 then R(x,m,a,s) else ReR(x,m,a,s)
    let rl(x:int, m:int, a:int, s:int)  = if m>294 then A(x,m,a,s) else R(x,m,a,s)
    let jxt(x:int, m:int, a:int, s:int)  = if s<2705 then A(x,m,a,s) else R(x,m,a,s)
    let jj(x:int, m:int, a:int, s:int)  = if s>1976 then R(x,m,a,s) elif s<735 then A(x,m,a,s) else R(x,m,a,s)
    let zp(x:int, m:int, a:int, s:int)  = if a>258 then R(x,m,a,s) elif x>1647 then A(x,m,a,s) else jj(x,m,a,s)
    let xk(x:int, m:int, a:int, s:int)  = if a>390 then A(x,m,a,s) elif x<198 then R(x,m,a,s) elif a>189 then A(x,m,a,s) else AeA(x,m,a,s)
    let cc(x:int, m:int, a:int, s:int)  = if s>2568 then R(x,m,a,s) else ReR(x,m,a,s)
    let kdf(x:int, m:int, a:int, s:int)  = if s>2631 then R(x,m,a,s) else ReR(x,m,a,s)
    let hp(x:int, m:int, a:int, s:int)  = if s<2877 then R(x,m,a,s) elif m>1762 then R(x,m,a,s) else ReR(x,m,a,s)
    let shj(x:int, m:int, a:int, s:int)  = if x<3833 then A(x,m,a,s) elif a>1667 then A(x,m,a,s) elif s<1535 then R(x,m,a,s) else A(x,m,a,s)   
    let rkt(x:int, m:int, a:int, s:int)  = if m<2656 then R(x,m,a,s) else ReR(x,m,a,s)

    let sml(x:int, m:int, a:int, s:int)  = if m>3925 then R(x,m,a,s) elif a>3709 then A(x,m,a,s) elif a>3380 then A(x,m,a,s) else AeA(x,m,a,s)
    let xtp(x:int, m:int, a:int, s:int)  = if m<2367 then A(x,m,a,s) else AeA(x,m,a,s)
    let pl(x:int, m:int, a:int, s:int)  = if x>1653 then R(x,m,a,s) else ReR(x,m,a,s)
    let gt(x:int, m:int, a:int, s:int)  = if a>700 then R(x,m,a,s) else A(x,m,a,s)
    let hrv(x:int, m:int, a:int, s:int)  = if a<3514 then R(x,m,a,s) else A(x,m,a,s)

    let lcp(x:int, m:int, a:int, s:int)  = if x<2839 then R(x,m,a,s) elif a>1232 then A(x,m,a,s) elif x>3245 then R(x,m,a,s) else ReR(x,m,a,s)
    let kxc(x:int, m:int, a:int, s:int)  = if x>774 then R(x,m,a,s) else A(x,m,a,s)
    let mv(x:int, m:int, a:int, s:int)  = if s>3013 then A(x,m,a,s) elif x>2298 then A(x,m,a,s) elif s<2800 then R(x,m,a,s) else A(x,m,a,s)
    let bbm(x:int, m:int, a:int, s:int)  = if m<3755 then R(x,m,a,s) else ReR(x,m,a,s)
    let gb(x:int, m:int, a:int, s:int)  = if a<3053 then R(x,m,a,s) elif a<3115 then R(x,m,a,s) else A(x,m,a,s)
    let qr(x:int, m:int, a:int, s:int)  = if a>1507 then A(x,m,a,s) elif x<236 then R(x,m,a,s) else ReR(x,m,a,s)
    let fd(x:int, m:int, a:int, s:int)  = if s<1125 then A(x,m,a,s) elif m>1688 then R(x,m,a,s) else A(x,m,a,s)
    let zm(x:int, m:int, a:int, s:int)  = if a<3311 then R(x,m,a,s) elif s<3539 then R(x,m,a,s) else ReR(x,m,a,s)
    let sh(x:int, m:int, a:int, s:int)  = if s<950 then R(x,m,a,s) elif s<1280 then R(x,m,a,s) elif a>1876 then A(x,m,a,s) else AeA(x,m,a,s)

    let vbx(x:int, m:int, a:int, s:int)  = if a>3526 then R(x,m,a,s) elif x<1759 then A(x,m,a,s) else AeA(x,m,a,s)
    let xsf(x:int, m:int, a:int, s:int)  = if a>3670 then A(x,m,a,s) elif x<2866 then A(x,m,a,s) else AeA(x,m,a,s)
    let lgf(x:int, m:int, a:int, s:int)  = if s>352 then A(x,m,a,s) else R(x,m,a,s)
    let mqf(x:int, m:int, a:int, s:int)  = if x<1738 then R(x,m,a,s) else ReR(x,m,a,s)
    let bdx(x:int, m:int, a:int, s:int)  = if a>1373 then R(x,m,a,s) else ReR(x,m,a,s)
    let pm(x:int, m:int, a:int, s:int)  = if s>3040 then R(x,m,a,s) elif s>2959 then R(x,m,a,s) elif x<1767 then R(x,m,a,s) else A(x,m,a,s)
    let kv(x:int, m:int, a:int, s:int)  = if m>1662 then R(x,m,a,s) else ReR(x,m,a,s)
    let dvh(x:int, m:int, a:int, s:int)  = if a>2032 then R(x,m,a,s) elif a<1895 then R(x,m,a,s) elif s<700 then R(x,m,a,s) else R(x,m,a,s)
    let cb(x:int, m:int, a:int, s:int)  = if m<3466 then R(x,m,a,s) elif x<3395 then A(x,m,a,s) else R(x,m,a,s)
    let mlh(x:int, m:int, a:int, s:int)  = if s>2509 then R(x,m,a,s) else A(x,m,a,s)

    

    let qt(x:int, m:int, a:int, s:int)  = if m>3464 then A(x,m,a,s) else R(x,m,a,s)
    let rtl(x:int, m:int, a:int, s:int)  = if m>3647 then A(x,m,a,s) else R(x,m,a,s)
    let mr(x:int, m:int, a:int, s:int)  = if s<2296 then A(x,m,a,s) else AeA(x,m,a,s)
    let zpn(x:int, m:int, a:int, s:int)  = if s>1287 then R(x,m,a,s) else A(x,m,a,s)
    let zmk(x:int, m:int, a:int, s:int)  = if m>3101 then R(x,m,a,s) elif a>1862 then R(x,m,a,s) else A(x,m,a,s)
    let fll(x:int, m:int, a:int, s:int)  = if m>559 then R(x,m,a,s) else ReR(x,m,a,s)
    let pjn(x:int, m:int, a:int, s:int)  = if a<3809 then A(x,m,a,s) elif x<1689 then A(x,m,a,s) elif a>3843 then R(x,m,a,s) else ReR(x,m,a,s)
    let gzx(x:int, m:int, a:int, s:int)  = if m>3247 then A(x,m,a,s) else R(x,m,a,s)
    
    let dkq(x:int, m:int, a:int, s:int)  = if m<2342 then A(x,m,a,s) elif x<836 then A(x,m,a,s) elif x<910 then A(x,m,a,s) else AeA(x,m,a,s)
    let zqt(x:int, m:int, a:int, s:int)  = if x<1765 then R(x,m,a,s) elif x>1814 then R(x,m,a,s) else ReR(x,m,a,s)

    let kdg(x:int, m:int, a:int, s:int)  = if x>1759 then A(x,m,a,s) elif m>2736 then R(x,m,a,s) else ReR(x,m,a,s)

    let ct(x:int, m:int, a:int, s:int)  = if a<1076 then A(x,m,a,s) elif s<2510 then R(x,m,a,s) elif x>89 then A(x,m,a,s) else AeA(x,m,a,s)
    let znq(x:int, m:int, a:int, s:int)  = if s>872 then R(x,m,a,s) elif s>389 then R(x,m,a,s) elif x<3462 then A(x,m,a,s) else R(x,m,a,s)
    let sjj(x:int, m:int, a:int, s:int)  = if m>3095 then R(x,m,a,s) elif s<922 then R(x,m,a,s) else ReR(x,m,a,s)
    let tqn(x:int, m:int, a:int, s:int)  = if x<632 then R(x,m,a,s) else A(x,m,a,s)

    let gnv(x:int, m:int, a:int, s:int)  = if s>881 then R(x,m,a,s) elif x>1689 then A(x,m,a,s) else AeA(x,m,a,s)
    let cq(x:int, m:int, a:int, s:int)  = if m>1527 then A(x,m,a,s) elif x>369 then R(x,m,a,s) else A(x,m,a,s)
    let tp(x:int, m:int, a:int, s:int)  = if m>3533 then R(x,m,a,s) elif m<3498 then A(x,m,a,s) else AeA(x,m,a,s)
    let rp(x:int, m:int, a:int, s:int)  = if a<3056 then R(x,m,a,s) else A(x,m,a,s)
    let cml(x:int, m:int, a:int, s:int)  = if s<2768 then R(x,m,a,s) else ReR(x,m,a,s)
    let tzc(x:int, m:int, a:int, s:int)  = if m>2622 then R(x,m,a,s) elif s<1490 then R(x,m,a,s) else A(x,m,a,s)
    let sc(x:int, m:int, a:int, s:int)  = if s>1038 then A(x,m,a,s) else R(x,m,a,s)

    let nr(x:int, m:int, a:int, s:int)  = if x<217 then A(x,m,a,s) elif x<248 then R(x,m,a,s) else A(x,m,a,s)
    let tcq(x:int, m:int, a:int, s:int)  = if x>1748 then R(x,m,a,s) elif x<1691 then A(x,m,a,s) else R(x,m,a,s)
    let zd(x:int, m:int, a:int, s:int)  = if m>3496 then R(x,m,a,s) elif m<3436 then R(x,m,a,s) else A(x,m,a,s)
    let gl(x:int, m:int, a:int, s:int)  = if s<3344 then R(x,m,a,s) elif s>3741 then R(x,m,a,s) elif m<3609 then R(x,m,a,s) else ReR(x,m,a,s)
    let djm(x:int, m:int, a:int, s:int)  = if m<1932 then A(x,m,a,s) else AeA(x,m,a,s)
    let rzh(x:int, m:int, a:int, s:int)  = if s>2629 then A(x,m,a,s) elif a<1890 then A(x,m,a,s) elif x<1182 then A(x,m,a,s) else AeA(x,m,a,s)
    let spb(x:int, m:int, a:int, s:int)  = if s<3380 then R(x,m,a,s) else A(x,m,a,s)
    let mfz(x:int, m:int, a:int, s:int)  = if s<3933 then R(x,m,a,s) else ReR(x,m,a,s)
    let kxn(x:int, m:int, a:int, s:int)  = if x>2596 then R(x,m,a,s) elif m>3047 then R(x,m,a,s) elif a>2293 then R(x,m,a,s) else A(x,m,a,s)
    let cnh(x:int, m:int, a:int, s:int)  = if s<2989 then R(x,m,a,s) elif s<3391 then R(x,m,a,s) elif a>1818 then A(x,m,a,s) else R(x,m,a,s)
    let lnp(x:int, m:int, a:int, s:int)  = if s<1688 then R(x,m,a,s) elif s>2271 then A(x,m,a,s) elif s>1968 then R(x,m,a,s) else ReR(x,m,a,s)
    let gmm(x:int, m:int, a:int, s:int)  = if x<3087 then A(x,m,a,s) else AeA(x,m,a,s)
    let pmh(x:int, m:int, a:int, s:int)  = if m<984 then A(x,m,a,s) else AeA(x,m,a,s)
    let jvx(x:int, m:int, a:int, s:int)  = if m<3147 then R(x,m,a,s) elif s<322 then R(x,m,a,s) else A(x,m,a,s)
    let dk(x:int, m:int, a:int, s:int)  = if a>2545 then A(x,m,a,s) elif x<2584 then R(x,m,a,s) elif s<3184 then A(x,m,a,s) else R(x,m,a,s)
    let kkq(x:int, m:int, a:int, s:int)  = if m<2016 then R(x,m,a,s) elif x<1586 then A(x,m,a,s) elif a<419 then A(x,m,a,s) else R(x,m,a,s)
    let lcr(x:int, m:int, a:int, s:int)  = if m>849 then R(x,m,a,s) elif a>1453 then R(x,m,a,s) elif m<764 then A(x,m,a,s) else R(x,m,a,s)
    let vjc(x:int, m:int, a:int, s:int)  = if a>2523 then R(x,m,a,s) elif s>108 then R(x,m,a,s) elif m>3085 then R(x,m,a,s) else ReR(x,m,a,s)
    let rz(x:int, m:int, a:int, s:int)  = if x>1108 then A(x,m,a,s) elif m>2183 then R(x,m,a,s) elif m>1020 then R(x,m,a,s) else R(x,m,a,s)
    let cnz(x:int, m:int, a:int, s:int)  = if a>2636 then A(x,m,a,s) else AeA(x,m,a,s)
    let rqc(x:int, m:int, a:int, s:int)  = if s<2857 then A(x,m,a,s) else R(x,m,a,s)
    let tpv(x:int, m:int, a:int, s:int)  = if s<353 then R(x,m,a,s) elif s<530 then R(x,m,a,s) elif s<748 then A(x,m,a,s) else AeA(x,m,a,s)
    let ptx(x:int, m:int, a:int, s:int)  = if m>3400 then A(x,m,a,s) elif x<1841 then A(x,m,a,s) elif s>2075 then R(x,m,a,s) else A(x,m,a,s)
    let nk(x:int, m:int, a:int, s:int)  = if s<2082 then A(x,m,a,s) elif s>2236 then R(x,m,a,s) else A(x,m,a,s)
    let nc(x:int, m:int, a:int, s:int)  = if s>803 then R(x,m,a,s) elif a<2184 then A(x,m,a,s) elif m>1658 then A(x,m,a,s) else AeA(x,m,a,s)
    let mhg(x:int, m:int, a:int, s:int)  = if a<1907 then A(x,m,a,s) elif m>740 then A(x,m,a,s) elif m>407 then A(x,m,a,s) else R(x,m,a,s)
    let xlf(x:int, m:int, a:int, s:int)  = if m>1757 then R(x,m,a,s) elif a>3792 then A(x,m,a,s) else AeA(x,m,a,s)
    let px(x:int, m:int, a:int, s:int)  = if m>1343 then R(x,m,a,s) else A(x,m,a,s)
    let cg(x:int, m:int, a:int, s:int)  = if a>2956 then R(x,m,a,s) else ReR(x,m,a,s)
    let xc(x:int, m:int, a:int, s:int)  = if m>2487 then A(x,m,a,s) else AeA(x,m,a,s)
    let gc(x:int, m:int, a:int, s:int)  = if a>3568 then R(x,m,a,s) else ReR(x,m,a,s)
    let mf(x:int, m:int, a:int, s:int)  = if m>3369 then A(x,m,a,s) elif m>3034 then R(x,m,a,s) elif s<1159 then A(x,m,a,s) else R(x,m,a,s)
    let zck(x:int, m:int, a:int, s:int)  = if m<2862 then R(x,m,a,s) elif a<3295 then R(x,m,a,s) else ReR(x,m,a,s)
    let mh(x:int, m:int, a:int, s:int)  = if s>829 then A(x,m,a,s) elif s<690 then R(x,m,a,s) else A(x,m,a,s)
    let mmg(x:int, m:int, a:int, s:int)  = if s<872 then A(x,m,a,s) elif x<1817 then R(x,m,a,s) else A(x,m,a,s)
    let ghz(x:int, m:int, a:int, s:int)  = if s<1263 then A(x,m,a,s) elif a>3172 then R(x,m,a,s) else ReR(x,m,a,s)
    let qdr(x:int, m:int, a:int, s:int)  = if m>2023 then A(x,m,a,s) elif x<1754 then A(x,m,a,s) else R(x,m,a,s)
    let qhd(x:int, m:int, a:int, s:int)  = if x<255 then R(x,m,a,s) elif a>1141 then R(x,m,a,s) else ReR(x,m,a,s)
    let rfx(x:int, m:int, a:int, s:int)  = if s<2820 then A(x,m,a,s) else AeA(x,m,a,s)
    let gtj(x:int, m:int, a:int, s:int)  = if x<196 then R(x,m,a,s) elif s>1193 then A(x,m,a,s) elif s<927 then R(x,m,a,s) else ReR(x,m,a,s)
    let zt(x:int, m:int, a:int, s:int)  = if a>2797 then R(x,m,a,s) elif s>2797 then R(x,m,a,s) elif a<2702 then R(x,m,a,s) else A(x,m,a,s)
    let dcg(x:int, m:int, a:int, s:int)  = if x<3587 then R(x,m,a,s) else A(x,m,a,s)
    let vbq(x:int, m:int, a:int, s:int)  = if s<3443 then R(x,m,a,s) else ReR(x,m,a,s)
    let dx(x:int, m:int, a:int, s:int)  = if x<387 then R(x,m,a,s) elif x>406 then R(x,m,a,s) elif s<1958 then A(x,m,a,s) else R(x,m,a,s)
    let qp(x:int, m:int, a:int, s:int)  = if s>1439 then R(x,m,a,s) elif x<2270 then R(x,m,a,s) elif x<2617 then R(x,m,a,s) else A(x,m,a,s)
    let fs(x:int, m:int, a:int, s:int)  = if s<3056 then A(x,m,a,s) elif a>1067 then A(x,m,a,s) else AeA(x,m,a,s)

    let pz(x:int, m:int, a:int, s:int)  = if x<109 then A(x,m,a,s) elif a<462 then A(x,m,a,s) elif m>3455 then R(x,m,a,s) else ReR(x,m,a,s)
    let nm(x:int, m:int, a:int, s:int)  = if s>1143 then A(x,m,a,s) elif a>1477 then A(x,m,a,s) elif a>1181 then R(x,m,a,s) else A(x,m,a,s)
    let kdk(x:int, m:int, a:int, s:int)  = if s<1608 then R(x,m,a,s) elif a<3613 then R(x,m,a,s) else A(x,m,a,s)
    let qx(x:int, m:int, a:int, s:int)  = if s>2554 then R(x,m,a,s) elif a>3943 then A(x,m,a,s) else AeA(x,m,a,s)
    let lgr(x:int, m:int, a:int, s:int)  = if m<2196 then R(x,m,a,s) else ReR(x,m,a,s)
    
    let cmd(x:int, m:int, a:int, s:int)  = if a<1530 then R(x,m,a,s) elif a<1617 then R(x,m,a,s) else ReR(x,m,a,s)
    let cpt(x:int, m:int, a:int, s:int)  = if m>2566 then R(x,m,a,s) elif x<1640 then A(x,m,a,s) else R(x,m,a,s)
    let zgj(x:int, m:int, a:int, s:int)  = if s>1980 then A(x,m,a,s) elif a<3427 then R(x,m,a,s) else A(x,m,a,s)
    let ccp(x:int, m:int, a:int, s:int)  = if m>3658 then R(x,m,a,s) elif m>3555 then A(x,m,a,s) else AeA(x,m,a,s)
    let dvn(x:int, m:int, a:int, s:int)  = if s>1767 then R(x,m,a,s) elif a>522 then A(x,m,a,s) else R(x,m,a,s)
    let vvm(x:int, m:int, a:int, s:int)  = if s>2965 then A(x,m,a,s) else AeA(x,m,a,s)
    let fsj(x:int, m:int, a:int, s:int)  = if x>3517 then A(x,m,a,s) else AeA(x,m,a,s)
    let nv(x:int, m:int, a:int, s:int)  = if s>3581 then R(x,m,a,s) elif s<3340 then A(x,m,a,s) else AeA(x,m,a,s)
    let rh(x:int, m:int, a:int, s:int)  = if a>813 then R(x,m,a,s) elif s>3042 then A(x,m,a,s) elif s>2781 then A(x,m,a,s) else R(x,m,a,s)
    let ggm(x:int, m:int, a:int, s:int)  = if s<2962 then A(x,m,a,s) elif x>2214 then A(x,m,a,s) else AeA(x,m,a,s)
    let vf(x:int, m:int, a:int, s:int)  = if s<349 then R(x,m,a,s) elif x>1227 then R(x,m,a,s) elif a<705 then A(x,m,a,s) else AeA(x,m,a,s)
    let lf(x:int, m:int, a:int, s:int)  = if m>2687 then A(x,m,a,s) elif x<1481 then A(x,m,a,s) elif m<2144 then R(x,m,a,s) else ReR(x,m,a,s)
    let sz(x:int, m:int, a:int, s:int)  = if s<2641 then A(x,m,a,s) elif m<2766 then R(x,m,a,s) elif s>3431 then A(x,m,a,s) else R(x,m,a,s)
    let tdp(x:int, m:int, a:int, s:int)  = if s>3500 then A(x,m,a,s) elif a<3931 then R(x,m,a,s) else A(x,m,a,s)
    let xs(x:int, m:int, a:int, s:int)  = if x<3279 then R(x,m,a,s) elif x>3661 then A(x,m,a,s) else AeA(x,m,a,s)
    let kbg(x:int, m:int, a:int, s:int)  = if s>778 then A(x,m,a,s) else AeA(x,m,a,s)
    let szx(x:int, m:int, a:int, s:int)  = if s>690 then A(x,m,a,s) elif m<2955 then R(x,m,a,s) elif x<1617 then A(x,m,a,s) else AeA(x,m,a,s)
    let zlt(x:int, m:int, a:int, s:int)  = if x<2589 then R(x,m,a,s) elif a>907 then A(x,m,a,s) elif a<376 then R(x,m,a,s) else ReR(x,m,a,s)
    let fsb(x:int, m:int, a:int, s:int)  = if s>1096 then A(x,m,a,s) elif m>1470 then A(x,m,a,s) elif s<415 then R(x,m,a,s) else ReR(x,m,a,s)
    let bg(x:int, m:int, a:int, s:int)  = if m>1789 then A(x,m,a,s) elif m<1559 then R(x,m,a,s) elif x<2819 then A(x,m,a,s) else R(x,m,a,s)
    let xvf(x:int, m:int, a:int, s:int)  = if m<2675 then A(x,m,a,s) elif a>3418 then A(x,m,a,s) elif x<1671 then R(x,m,a,s) else ReR(x,m,a,s)
    let fr(x:int, m:int, a:int, s:int)  = if a>3763 then R(x,m,a,s) elif m<1443 then A(x,m,a,s) else R(x,m,a,s)
    let xcj(x:int, m:int, a:int, s:int)  = if s<881 then A(x,m,a,s) else R(x,m,a,s)
    let tfn(x:int, m:int, a:int, s:int)  = if x<1411 then R(x,m,a,s) else A(x,m,a,s)
    let tt(x:int, m:int, a:int, s:int)  = if x<1676 then R(x,m,a,s) else ReR(x,m,a,s)
    let gnt(x:int, m:int, a:int, s:int)  = if x>1725 then R(x,m,a,s) else A(x,m,a,s)
    let ttv(x:int, m:int, a:int, s:int)  = if m>1339 then A(x,m,a,s) else AeA(x,m,a,s)
    let pk(x:int, m:int, a:int, s:int)  = if a>2233 then R(x,m,a,s) else A(x,m,a,s)
    let pr(x:int, m:int, a:int, s:int)  = if m<3049 then R(x,m,a,s) else ReR(x,m,a,s)
    let mrk(x:int, m:int, a:int, s:int)  = if m>2755 then A(x,m,a,s) else AeA(x,m,a,s)
    let tkd(x:int, m:int, a:int, s:int)  = if x>2536 then A(x,m,a,s) else R(x,m,a,s)
    let gg(x:int, m:int, a:int, s:int)  = if x>3270 then A(x,m,a,s) elif a>2494 then A(x,m,a,s) else R(x,m,a,s)
    let qv(x:int, m:int, a:int, s:int)  = if s>1679 then R(x,m,a,s) else ReR(x,m,a,s)
    let dt(x:int, m:int, a:int, s:int)  = if a>2086 then R(x,m,a,s) elif s>126 then R(x,m,a,s) else ReR(x,m,a,s)
    let tfz(x:int, m:int, a:int, s:int)  = if x<1427 then R(x,m,a,s) elif a>497 then R(x,m,a,s) elif x>1670 then R(x,m,a,s) else R(x,m,a,s)
    let tpn(x:int, m:int, a:int, s:int)  = if s>1975 then R(x,m,a,s) elif s<1639 then R(x,m,a,s) elif a<2071 then R(x,m,a,s) else A(x,m,a,s)
    let bhr(x:int, m:int, a:int, s:int)  = if s>992 then A(x,m,a,s) elif x>1683 then A(x,m,a,s) elif m<3407 then A(x,m,a,s) else AeA(x,m,a,s)
    let nx(x:int, m:int, a:int, s:int)  = if s>2469 then R(x,m,a,s) elif a<3826 then R(x,m,a,s) else A(x,m,a,s)
    let gpj(x:int, m:int, a:int, s:int)  = if a>2285 then R(x,m,a,s) elif s>2372 then R(x,m,a,s) else tpn(x,m,a,s)
    let mvt(x:int, m:int, a:int, s:int)  = if a>3819 then R(x,m,a,s) elif s<2734 then A(x,m,a,s) elif x<1357 then A(x,m,a,s) else AeA(x,m,a,s)
    let fdt(x:int, m:int, a:int, s:int)  = if m<1287 then R(x,m,a,s) elif a>3344 then R(x,m,a,s) else ReR(x,m,a,s)
    let pvc(x:int, m:int, a:int, s:int)  = if s<1234 then R(x,m,a,s) elif m>3049 then R(x,m,a,s) elif a<3802 then R(x,m,a,s) else A(x,m,a,s)
    let dst(x:int, m:int, a:int, s:int)  = if a>3822 then R(x,m,a,s) elif m>1505 then A(x,m,a,s) else R(x,m,a,s)
    let ftt(x:int, m:int, a:int, s:int)  = if s>1217 then A(x,m,a,s) elif a<3222 then R(x,m,a,s) else A(x,m,a,s)
    let ck(x:int, m:int, a:int, s:int)  = if m>2095 then A(x,m,a,s) elif a<2991 then A(x,m,a,s) else AeA(x,m,a,s)
    let mhs(x:int, m:int, a:int, s:int)  = if m>3601 then R(x,m,a,s) elif m<3327 then R(x,m,a,s) elif x>2985 then A(x,m,a,s) else AeA(x,m,a,s)
    let hnt(x:int, m:int, a:int, s:int)  = if s<1237 then A(x,m,a,s) elif x<2124 then A(x,m,a,s) else AeA(x,m,a,s)
    let kdz(x:int, m:int, a:int, s:int)  = if a>3816 then A(x,m,a,s) elif s<2322 then R(x,m,a,s) elif s<2913 then R(x,m,a,s) else A(x,m,a,s)
    let bzg(x:int, m:int, a:int, s:int)  = if s<1344 then R(x,m,a,s) else A(x,m,a,s)
    let rd(x:int, m:int, a:int, s:int)  = if x>3336 then R(x,m,a,s) elif a>1276 then A(x,m,a,s) elif a<1192 then A(x,m,a,s) else R(x,m,a,s)
    let cm(x:int, m:int, a:int, s:int)  = if s>1819 then A(x,m,a,s) elif x<2244 then R(x,m,a,s) else A(x,m,a,s)
    let rc(x:int, m:int, a:int, s:int)  = if s<102 then R(x,m,a,s) else ReR(x,m,a,s)
    let ss(x:int, m:int, a:int, s:int)  = if x<3880 then A(x,m,a,s) elif x>3942 then R(x,m,a,s) elif s>475 then A(x,m,a,s) else AeA(x,m,a,s)
    let xcn(x:int, m:int, a:int, s:int)  = if m<1831 then R(x,m,a,s) elif x>1275 then A(x,m,a,s) elif m>2825 then A(x,m,a,s) else AeA(x,m,a,s)
    let nlm(x:int, m:int, a:int, s:int)  = if s<3380 then A(x,m,a,s) elif s<3708 then R(x,m,a,s) else ReR(x,m,a,s)
    let fzl(x:int, m:int, a:int, s:int)  = if x>187 then R(x,m,a,s) elif a<1934 then R(x,m,a,s) else A(x,m,a,s)
    let sp(x:int, m:int, a:int, s:int)  = if a<1106 then A(x,m,a,s) elif x>2784 then A(x,m,a,s) elif s>3808 then A(x,m,a,s) else AeA(x,m,a,s)
    let zvj(x:int, m:int, a:int, s:int)  = if a<3736 then A(x,m,a,s) elif s>168 then R(x,m,a,s) elif m>520 then R(x,m,a,s) else A(x,m,a,s)
    let vs(x:int, m:int, a:int, s:int)  = if s>3829 then A(x,m,a,s) elif x>1496 then A(x,m,a,s) elif m>721 then R(x,m,a,s) else ReR(x,m,a,s)
    let nh(x:int, m:int, a:int, s:int)  = if m>2777 then R(x,m,a,s) elif a>2450 then A(x,m,a,s) elif x<3023 then R(x,m,a,s) else A(x,m,a,s)
    let lq(x:int, m:int, a:int, s:int)  = if m<3533 then A(x,m,a,s) elif s>2891 then A(x,m,a,s) elif s>1978 then R(x,m,a,s) else ReR(x,m,a,s)
    let ts(x:int, m:int, a:int, s:int)  = if x>2576 then A(x,m,a,s) elif x<2156 then A(x,m,a,s) else R(x,m,a,s)
    let rr(x:int, m:int, a:int, s:int)  = if a>3120 then A(x,m,a,s) elif a>3101 then R(x,m,a,s) elif x<1787 then R(x,m,a,s) else ReR(x,m,a,s)
    let lz(x:int, m:int, a:int, s:int)  = if m<2165 then A(x,m,a,s) elif m>2321 then R(x,m,a,s) elif s<2840 then R(x,m,a,s) else ReR(x,m,a,s)
    let dj(x:int, m:int, a:int, s:int)  = if x<2303 then A(x,m,a,s) elif x>2600 then R(x,m,a,s) else A(x,m,a,s)
    let vfx(x:int, m:int, a:int, s:int)  = if x>3110 then A(x,m,a,s) elif m<3382 then R(x,m,a,s) elif a<3064 then R(x,m,a,s) else A(x,m,a,s)
    let mrf(x:int, m:int, a:int, s:int)  = if x>1667 then A(x,m,a,s) elif a<3699 then R(x,m,a,s) else ReR(x,m,a,s)
    let sf(x:int, m:int, a:int, s:int)  = if x<2428 then R(x,m,a,s) elif s>1024 then A(x,m,a,s) elif s<385 then R(x,m,a,s) else ReR(x,m,a,s)
    let tg(x:int, m:int, a:int, s:int)  = if m>3363 then R(x,m,a,s) elif m<2905 then A(x,m,a,s) elif m>3162 then A(x,m,a,s) else R(x,m,a,s)
    let hg(x:int, m:int, a:int, s:int)  = if s<941 then R(x,m,a,s) elif a<158 then R(x,m,a,s) elif s>1333 then R(x,m,a,s) else A(x,m,a,s)
    let dct(x:int, m:int, a:int, s:int)  = if x<1655 then R(x,m,a,s) elif s>598 then A(x,m,a,s) elif m>3271 then R(x,m,a,s) else A(x,m,a,s)



    // hello
    // hello
    // hello
    // hello
    // hello
    // hello

    let kf(x:int, m:int, a:int, s:int)  = if s<815 then A(x,m,a,s) elif a>1938 then R(x,m,a,s) else nm(x,m,a,s)
    let xhk(x:int, m:int, a:int, s:int)  = if x<1562 then gkk(x,m,a,s) else R(x,m,a,s)
    let ff(x:int, m:int, a:int, s:int)  = if a>278 then jp(x,m,a,s) elif s>2093 then ktt(x,m,a,s) elif m>425 then R(x,m,a,s) else ReR(x,m,a,s)

    let sb(x:int, m:int, a:int, s:int)  = if a<157 then xhk(x,m,a,s) elif x<1408 then qdf(x,m,a,s) elif m<1174 then ff(x,m,a,s) else zp(x,m,a,s)

    let sm(x:int, m:int, a:int, s:int)  = if x<753 then cc(x,m,a,s) else kdf(x,m,a,s)
    let pgd(x:int, m:int, a:int, s:int)  = if a<3436 then A(x,m,a,s) elif x<926 then nhv(x,m,a,s) elif x>995 then xmv(x,m,a,s) else A(x,m,a,s)
    let hfm(x:int, m:int, a:int, s:int)  = if x<661 then gm(x,m,a,s) else fck(x,m,a,s)

    let df(x:int, m:int, a:int, s:int)  = if a<2667 then sm(x,m,a,s) elif x>794 then pgd(x,m,a,s) else hfm(x,m,a,s)

    let ftv(x:int, m:int, a:int, s:int)  = if m>2340 then R(x,m,a,s) elif a<623 then A(x,m,a,s) elif m<1159 then A(x,m,a,s) else AeA(x,m,a,s)
    
    let qk(x:int, m:int, a:int, s:int)  = if a>3005 then R(x,m,a,s) elif m<2895 then R(x,m,a,s) else ReR(x,m,a,s)
    let tqs(x:int, m:int, a:int, s:int)  = if x>1231 then A(x,m,a,s) else A(x,m,a,s)
    let jd(x:int, m:int, a:int, s:int)  = if x<720 then A(x,m,a,s) else AeA(x,m,a,s)
    let pmf(x:int, m:int, a:int, s:int)  = if x>1307 then R(x,m,a,s) else ReR(x,m,a,s)
    let jx(x:int, m:int, a:int, s:int)  = if m>3503 then R(x,m,a,s) else ReR(x,m,a,s)
    let xcv(x:int, m:int, a:int, s:int)  = if x>1264 then A(x,m,a,s) elif s>3562 then A(x,m,a,s) else R(x,m,a,s)

    let mht(x:int, m:int, a:int, s:int)  = if s>1243 then A(x,m,a,s) else AeA(x,m,a,s)
    let dlg(x:int, m:int, a:int, s:int)  = if m>871 then A(x,m,a,s) elif a>1668 then A(x,m,a,s) else R(x,m,a,s)
    let vxz(x:int, m:int, a:int, s:int)  = if s>126 then R(x,m,a,s) elif a<3458 then R(x,m,a,s) elif a<3681 then A(x,m,a,s) else AeA(x,m,a,s)
    let bm(x:int, m:int, a:int, s:int)  = if x<2634 then A(x,m,a,s) else R(x,m,a,s)


    let fv(x:int, m:int, a:int, s:int)  = if s<624 then ftv(x,m,a,s) elif s>1101 then A(x,m,a,s) elif a>691 then A(x,m,a,s) else R(x,m,a,s)
    let jh(x:int, m:int, a:int, s:int)  = if s<911 then A(x,m,a,s) elif m>3035 then R(x,m,a,s) elif x>622 then A(x,m,a,s) else AeA(x,m,a,s)
    let trl(x:int, m:int, a:int, s:int)  = if x>770 then A(x,m,a,s) elif m>2294 then jh(x,m,a,s) else hsz(x,m,a,s)
    
    let fc(x:int, m:int, a:int, s:int)  = if a<1041 then fv(x,m,a,s) else trl(x,m,a,s)
    let sl(x:int, m:int, a:int, s:int)  = if m>3167 then A(x,m,a,s) elif m>2576 then qk(x,m,a,s) else A(x,m,a,s)
    let tj(x:int, m:int, a:int, s:int)  = if a>3586 then mk(x,m,a,s) elif a<3287 then mht(x,m,a,s) else R(x,m,a,s)
    let dxk(x:int, m:int, a:int, s:int)  = if x<291 then gph(x,m,a,s) else R(x,m,a,s)
    let hzs(x:int, m:int, a:int, s:int)  = if m>2250 then sl(x,m,a,s) elif a>3055 then tj(x,m,a,s) else dxk(x,m,a,s)

    let zv(x:int, m:int, a:int, s:int)  = if x>188 then jxt(x,m,a,s) elif x<78 then hp(x,m,a,s) else R(x,m,a,s)
    let vhs(x:int, m:int, a:int, s:int)  = if s>3174 then dxt(x,m,a,s) else zv(x,m,a,s)

    let pxm(x:int, m:int, a:int, s:int)  = if a>2777 then R(x,m,a,s) elif a>2129 then R(x,m,a,s) elif m<412 then A(x,m,a,s) else R(x,m,a,s)

    let zrl(x:int, m:int, a:int, s:int)  = if m>712 then jd(x,m,a,s) else pxm(x,m,a,s)
    let jkr(x:int, m:int, a:int, s:int)  = if m<2927 then kxc(x,m,a,s) elif a>2049 then R(x,m,a,s) else sh(x,m,a,s)
    let hr(x:int, m:int, a:int, s:int)  = if a<3242 then zz(x,m,a,s) elif m>2967 then rtl(x,m,a,s) else dkq(x,m,a,s)
    let kl(x:int, m:int, a:int, s:int)  = if x>812 then A(x,m,a,s) else tqn(x,m,a,s)
    let nnt(x:int, m:int, a:int, s:int)  = if m<1816 then zrl(x,m,a,s) elif a<2781 then jkr(x,m,a,s) elif s>660 then hr(x,m,a,s) else kl(x,m,a,s)
    let zvv(x:int, m:int, a:int, s:int)  = if s>1686 then df(x,m,a,s) elif a<1613 then fc(x,m,a,s) else nnt(x,m,a,s)
    let nsv(x:int, m:int, a:int, s:int)  = if a<1742 then R(x,m,a,s) elif x>142 then R(x,m,a,s) else dvh(x,m,a,s)

    let xpl(x:int, m:int, a:int, s:int)  = if a<1817 then tzc(x,m,a,s) elif x>169 then nr(x,m,a,s) elif a>2176 then R(x,m,a,s) else ReR(x,m,a,s)
    let pf(x:int, m:int, a:int, s:int)  = if s<504 then jvx(x,m,a,s) elif m>3148 then mh(x,m,a,s) elif m>3049 then sjj(x,m,a,s) else A(x,m,a,s)

    let lx(x:int, m:int, a:int, s:int)  = if m<3512 then cml(x,m,a,s) elif s>2892 then R(x,m,a,s) else fzl(x,m,a,s)

    let sq(x:int, m:int, a:int, s:int)  = if m<2979 then xpl(x,m,a,s) elif s>1347 then lx(x,m,a,s) elif m>3340 then nsv(x,m,a,s) else pf(x,m,a,s)
    let bp(x:int, m:int, a:int, s:int)  = if s>707 then nsp(x,m,a,s) else cq(x,m,a,s)
    let fms(x:int, m:int, a:int, s:int)  = if a<1845 then rfx(x,m,a,s) elif s<2483 then dx(x,m,a,s) elif a<2108 then R(x,m,a,s) else ReR(x,m,a,s)

    let ths(x:int, m:int, a:int, s:int)  = if s<1404 then bp(x,m,a,s) else fms(x,m,a,s)
    let fqp(x:int, m:int, a:int, s:int)  = if a<2237 then mr(x,m,a,s) elif a<2303 then R(x,m,a,s) else A(x,m,a,s)
    let nzf(x:int, m:int, a:int, s:int)  = if m>296 then R(x,m,a,s) elif a<1691 then A(x,m,a,s) else R(x,m,a,s)

    let qj(x:int, m:int, a:int, s:int)  = if s<1997 then A(x,m,a,s) else nzf(x,m,a,s)
    let mxg(x:int, m:int, a:int, s:int)  = if m>2191 then A(x,m,a,s) elif s>2784 then R(x,m,a,s) elif a>2067 then R(x,m,a,s) else ReR(x,m,a,s)

    let gv(x:int, m:int, a:int, s:int)  = if x>40 then R(x,m,a,s) elif a<2021 then R(x,m,a,s) elif m<1655 then A(x,m,a,s) else AeA(x,m,a,s)

    let tq(x:int, m:int, a:int, s:int)  = if x>99 then A(x,m,a,s) elif s>780 then A(x,m,a,s) else gv(x,m,a,s)
    let cmn(x:int, m:int, a:int, s:int)  = if m<1877 then A(x,m,a,s) elif x>103 then A(x,m,a,s) else mxg(x,m,a,s)
    let db(x:int, m:int, a:int, s:int)  = if a>1922 then fqp(x,m,a,s) elif m>469 then kqc(x,m,a,s) else qj(x,m,a,s)
    let lt(x:int, m:int, a:int, s:int)  = if x>247 then A(x,m,a,s) elif x<218 then R(x,m,a,s) else ReR(x,m,a,s)
    let pt(x:int, m:int, a:int, s:int)  = if x<188 then tgj(x,m,a,s) elif m<1898 then lt(x,m,a,s) elif s<2956 then lgr(x,m,a,s) else A(x,m,a,s)
    let kmq(x:int, m:int, a:int, s:int)  = if x>151 then qr(x,m,a,s) elif m<1575 then A(x,m,a,s) elif s>3253 then cmd(x,m,a,s) else A(x,m,a,s)

    let gfq(x:int, m:int, a:int, s:int)  = if s<2146 then tq(x,m,a,s) elif a>1886 then cmn(x,m,a,s) elif a>1662 then pt(x,m,a,s) else kmq(x,m,a,s)
    let bvc(x:int, m:int, a:int, s:int)  = if x>285 then ths(x,m,a,s) elif m>2387 then sq(x,m,a,s) elif m<1094 then db(x,m,a,s) else gfq(x,m,a,s)

    let xrp(x:int, m:int, a:int, s:int)  = if x<177 then rh(x,m,a,s) else spb(x,m,a,s)
    let tmh(x:int, m:int, a:int, s:int)  = if m<1627 then A(x,m,a,s) elif m<1805 then A(x,m,a,s) elif a<756 then R(x,m,a,s) else A(x,m,a,s)

    let xsq(x:int, m:int, a:int, s:int)  = if m<2092 then tmh(x,m,a,s) elif s>766 then gtj(x,m,a,s) elif a<651 then xk(x,m,a,s) else A(x,m,a,s)

    let zzc(x:int, m:int, a:int, s:int)  = if s<1510 then xsq(x,m,a,s) elif s<2530 then nk(x,m,a,s) else xrp(x,m,a,s)
    let dc(x:int, m:int, a:int, s:int)  = if x<363 then A(x,m,a,s) elif s>1439 then hgr(x,m,a,s) elif m>3285 then A(x,m,a,s) else kbg(x,m,a,s)
    let mp(x:int, m:int, a:int, s:int)  = if s<2457 then R(x,m,a,s) elif s<3073 then R(x,m,a,s) else A(x,m,a,s)

    let mjb(x:int, m:int, a:int, s:int)  = if m>3647 then A(x,m,a,s) elif a<883 then pz(x,m,a,s) else mp(x,m,a,s)

    let kd(x:int, m:int, a:int, s:int)  = if x>243 then dc(x,m,a,s) elif m<3343 then dvn(x,m,a,s) else mjb(x,m,a,s)
    let rtx(x:int, m:int, a:int, s:int)  = if a<714 then lm(x,m,a,s) elif s>1097 then qhd(x,m,a,s) else R(x,m,a,s)
    let jqg(x:int, m:int, a:int, s:int)  = if s<2459 then hzs(x,m,a,s) else vhs(x,m,a,s)
    let tx(x:int, m:int, a:int, s:int)  = if a<835 then R(x,m,a,s) elif s>3130 then skj(x,m,a,s) else ct(x,m,a,s)
    let fj(x:int, m:int, a:int, s:int)  = if x>267 then cl(x,m,a,s) elif s>3135 then A(x,m,a,s) elif a>576 then A(x,m,a,s) else AeA(x,m,a,s)
    let qh(x:int, m:int, a:int, s:int)  = if x>294 then A(x,m,a,s) else vvm(x,m,a,s)
    let kz(x:int, m:int, a:int, s:int)  = if x<169 then tx(x,m,a,s) elif m>726 then fj(x,m,a,s) else qh(x,m,a,s)

    let jq(x:int, m:int, a:int, s:int)  = if a<541 then pmh(x,m,a,s) elif a<926 then R(x,m,a,s) else A(x,m,a,s)

    let bps(x:int, m:int, a:int, s:int)  = if m<507 then rtx(x,m,a,s) else jq(x,m,a,s)
    let mb(x:int, m:int, a:int, s:int)  = if m>2654 then kd(x,m,a,s) elif m>1299 then zzc(x,m,a,s) elif s<1993 then bps(x,m,a,s) else kz(x,m,a,s)
    let jf(x:int, m:int, a:int, s:int)  = if x>441 then zvv(x,m,a,s) elif a>2404 then jqg(x,m,a,s) elif a>1410 then bvc(x,m,a,s) else mb(x,m,a,s)
    let tlf(x:int, m:int, a:int, s:int)  = if x<3232 then A(x,m,a,s) elif m<228 then R(x,m,a,s) elif m>301 then R(x,m,a,s) else ReR(x,m,a,s)
    let cz(x:int, m:int, a:int, s:int)  = if s>3104 then R(x,m,a,s) elif a<1812 then A(x,m,a,s) else R(x,m,a,s)

    let hn(x:int, m:int, a:int, s:int)  = if a>2033 then R(x,m,a,s) elif s<2640 then A(x,m,a,s) elif m<1587 then dlg(x,m,a,s) else cz(x,m,a,s)

    let knb(x:int, m:int, a:int, s:int)  = if a>1181 then qc(x,m,a,s) else A(x,m,a,s)

    let jn(x:int, m:int, a:int, s:int)  = if a<1479 then knb(x,m,a,s) else hn(x,m,a,s)

    let lvj(x:int, m:int, a:int, s:int)  = if x>3711 then zpn(x,m,a,s) elif x<3392 then tlf(x,m,a,s) else R(x,m,a,s)
    let hxr(x:int, m:int, a:int, s:int)  = if a<1675 then R(x,m,a,s) elif a<2007 then rzh(x,m,a,s) else pk(x,m,a,s)
    let rx(x:int, m:int, a:int, s:int)  = if m<3079 then mrk(x,m,a,s) elif a>1474 then R(x,m,a,s) else ReR(x,m,a,s)
    let fx(x:int, m:int, a:int, s:int)  = if m<3263 then cnh(x,m,a,s) elif a<1482 then A(x,m,a,s) else AeA(x,m,a,s)

    let zjl(x:int, m:int, a:int, s:int)  = if m<2130 then hxr(x,m,a,s) elif s<1643 then zmk(x,m,a,s) elif x<1224 then rx(x,m,a,s) else fx(x,m,a,s)
    let jxg(x:int, m:int, a:int, s:int)  = if x<1373 then A(x,m,a,s) elif m>2224 then A(x,m,a,s) elif a<1304 then A(x,m,a,s) else AeA(x,m,a,s)
    let cff(x:int, m:int, a:int, s:int)  = if a<1614 then jxg(x,m,a,s) else nc(x,m,a,s)

    let vh(x:int, m:int, a:int, s:int)  = if x<1421 then cff(x,m,a,s) else kf(x,m,a,s)
    let jjv(x:int, m:int, a:int, s:int)  = if a<1298 then bmj(x,m,a,s) elif x<1415 then cd(x,m,a,s) else A(x,m,a,s)
    let ztz(x:int, m:int, a:int, s:int)  = if m>1355 then lf(x,m,a,s) else R(x,m,a,s)
    let gf(x:int, m:int, a:int, s:int)  = if a<1839 then jjv(x,m,a,s) elif s>3144 then tfn(x,m,a,s) elif x<1424 then gpj(x,m,a,s) else ztz(x,m,a,s)

    let vn(x:int, m:int, a:int, s:int)  = if x>1525 then jn(x,m,a,s) elif x<1345 then zjl(x,m,a,s) elif s<1431 then vh(x,m,a,s) else gf(x,m,a,s)
    let rf(x:int, m:int, a:int, s:int)  = if m>2639 then A(x,m,a,s) elif s>3257 then zm(x,m,a,s) else jg(x,m,a,s)
    let rj(x:int, m:int, a:int, s:int)  = if m<1592 then ggm(x,m,a,s) elif x>2353 then fs(x,m,a,s) elif s>2993 then A(x,m,a,s) else AeA(x,m,a,s)
    let qz(x:int, m:int, a:int, s:int)  = if a<1148 then R(x,m,a,s) elif a<1473 then rd(x,m,a,s) elif x<3400 then A(x,m,a,s) else R(x,m,a,s)

    let dq(x:int, m:int, a:int, s:int)  = if x<2671 then rj(x,m,a,s) else qz(x,m,a,s)
    let qpl(x:int, m:int, a:int, s:int)  = if s<3540 then mv(x,m,a,s) else A(x,m,a,s)
    let mz(x:int, m:int, a:int, s:int)  = if a<2856 then R(x,m,a,s) elif a>3430 then pvc(x,m,a,s) elif x<2330 then ftt(x,m,a,s) else pg(x,m,a,s)
    let vfr(x:int, m:int, a:int, s:int)  = if m>3672 then R(x,m,a,s) elif x<3116 then rc(x,m,a,s) else R(x,m,a,s)
    let bc(x:int, m:int, a:int, s:int)  = if x>2604 then jx(x,m,a,s) elif x>2331 then jcj(x,m,a,s) elif a<2724 then A(x,m,a,s) else R(x,m,a,s)
    let hzr(x:int, m:int, a:int, s:int)  = if a>2332 then vjc(x,m,a,s) elif a<2223 then dt(x,m,a,s) else kxn(x,m,a,s)
    let zn(x:int, m:int, a:int, s:int)  = if m>2957 then vxz(x,m,a,s) else cgg(x,m,a,s)
    let rhl(x:int, m:int, a:int, s:int)  = if s>251 then bc(x,m,a,s) elif m>3504 then vfr(x,m,a,s) elif a<2788 then hzr(x,m,a,s) else zn(x,m,a,s)

    let fdf(x:int, m:int, a:int, s:int)  = if m<1679 then kdk(x,m,a,s) elif m>2987 then R(x,m,a,s) else gc(x,m,a,s)
    let smf(x:int, m:int, a:int, s:int)  = if m<1642 then A(x,m,a,s) elif m>2204 then R(x,m,a,s) elif a>250 then A(x,m,a,s) else AeA(x,m,a,s)
    let vg(x:int, m:int, a:int, s:int)  = if m>1872 then gnv(x,m,a,s) elif s>989 then zqt(x,m,a,s) else gh(x,m,a,s)

    let hqh(x:int, m:int, a:int, s:int)  = if m<502 then R(x,m,a,s) elif s>575 then R(x,m,a,s) elif a<3429 then lgf(x,m,a,s) else vbx(x,m,a,s)
    let djp(x:int, m:int, a:int, s:int)  = if s>588 then R(x,m,a,s) elif s<375 then zvj(x,m,a,s) else R(x,m,a,s)


    let crv(x:int, m:int, a:int, s:int)  = if m>1119 then vg(x,m,a,s) elif a>3589 then djp(x,m,a,s) else hqh(x,m,a,s)
    let cps(x:int, m:int, a:int, s:int)  = if a<982 then R(x,m,a,s) elif x>3117 then R(x,m,a,s) elif x<2335 then A(x,m,a,s) else R(x,m,a,s)
    let pqh(x:int, m:int, a:int, s:int)  = if s>328 then A(x,m,a,s) elif m>3037 then R(x,m,a,s) elif x>1636 then A(x,m,a,s) else AeA(x,m,a,s)
    let br(x:int, m:int, a:int, s:int)  = if a>981 then A(x,m,a,s) elif s<3008 then R(x,m,a,s) else A(x,m,a,s)
    let zdq(x:int, m:int, a:int, s:int)  = if s>346 then R(x,m,a,s) elif m>1682 then R(x,m,a,s) elif a>2849 then A(x,m,a,s) else R(x,m,a,s)

    let zk(x:int, m:int, a:int, s:int)  = if m>2885 then qt(x,m,a,s) elif s>3306 then A(x,m,a,s) else zt(x,m,a,s)

    let ghf(x:int, m:int, a:int, s:int)  = if x<1244 then vbq(x,m,a,s) else zk(x,m,a,s)
    let zkq(x:int, m:int, a:int, s:int)  = if s<3264 then rqc(x,m,a,s) else R(x,m,a,s)
    let srk(x:int, m:int, a:int, s:int)  = if s<564 then zdq(x,m,a,s) else A(x,m,a,s)

    let zfh(x:int, m:int, a:int, s:int)  = if s<1106 then srk(x,m,a,s) else djm(x,m,a,s)
    let tfb(x:int, m:int, a:int, s:int)  = if s<3203 then R(x,m,a,s) elif x<1370 then R(x,m,a,s) elif s<3645 then A(x,m,a,s) else vs(x,m,a,s)
    let vkp(x:int, m:int, a:int, s:int)  = if m>791 then R(x,m,a,s) elif a<2954 then mj(x,m,a,s) else rl(x,m,a,s)
    let fg(x:int, m:int, a:int, s:int)  = if m>1182 then rp(x,m,a,s) elif m<530 then A(x,m,a,s) elif m<823 then A(x,m,a,s) else R(x,m,a,s)
    let nzj(x:int, m:int, a:int, s:int)  = if a<2917 then zkq(x,m,a,s) elif a<2997 then vkp(x,m,a,s) elif a>3090 then tfb(x,m,a,s) else fg(x,m,a,s)
    let tbr(x:int, m:int, a:int, s:int)  = if s<2338 then zfh(x,m,a,s) elif m>1880 then ghf(x,m,a,s) else nzj(x,m,a,s)
    let ndn(x:int, m:int, a:int, s:int)  = if a>3628 then sz(x,m,a,s) elif m>2877 then kkt(x,m,a,s) else gmm(x,m,a,s)
    let jl(x:int, m:int, a:int, s:int)  = if s>1964 then R(x,m,a,s) else ReR(x,m,a,s)

    let fm(x:int, m:int, a:int, s:int)  = if a>3743 then lq(x,m,a,s) elif s<2464 then jl(x,m,a,s) elif s>3039 then mhs(x,m,a,s) else ts(x,m,a,s)
    let lzz(x:int, m:int, a:int, s:int)  = if m<3111 then ndn(x,m,a,s) else fm(x,m,a,s)
    let pqm(x:int, m:int, a:int, s:int)  = if a>3473 then fr(x,m,a,s) else ReR(x,m,a,s)



    let dgt(x:int, m:int, a:int, s:int)  = if s>1976 then R(x,m,a,s) elif a>2943 then A(x,m,a,s) elif m<250 then A(x,m,a,s) else AeA(x,m,a,s)

    let xjj(x:int, m:int, a:int, s:int)  = if a<3697 then rkx(x,m,a,s) else A(x,m,a,s)
    let rb(x:int, m:int, a:int, s:int)  = if s>2690 then xd(x,m,a,s) else gp(x,m,a,s)

    let ccn(x:int, m:int, a:int, s:int)  = if x>1109 then xjj(x,m,a,s) else rb(x,m,a,s)
    let fsz(x:int, m:int, a:int, s:int)  = if m<3908 then R(x,m,a,s) elif m<3950 then sml(x,m,a,s) elif a>3520 then R(x,m,a,s) else tcq(x,m,a,s)





    let nbq(x:int, m:int, a:int, s:int)  = if a<3565 then R(x,m,a,s) else hk(x,m,a,s)
    let lpz(x:int, m:int, a:int, s:int)  = if a>3507 then pqh(x,m,a,s) elif m>2945 then A(x,m,a,s) else zms(x,m,a,s)
    let kvp(x:int, m:int, a:int, s:int)  = if m<2615 then xc(x,m,a,s) elif a<3542 then xvf(x,m,a,s) else A(x,m,a,s)
    let sth(x:int, m:int, a:int, s:int)  = if x>1719 then nbq(x,m,a,s) elif m>2754 then lpz(x,m,a,s) elif s<346 then cpt(x,m,a,s) else kvp(x,m,a,s)

    let jpj(x:int, m:int, a:int, s:int)  = if x<1767 then gnt(x,m,a,s) else A(x,m,a,s)


    let lh(x:int, m:int, a:int, s:int)  = if a<2846 then A(x,m,a,s) elif m>2459 then ptx(x,m,a,s) elif s>1865 then lz(x,m,a,s) else gz(x,m,a,s)
    let ntr(x:int, m:int, a:int, s:int)  = if a<2924 then R(x,m,a,s) elif x<1760 then mqf(x,m,a,s) elif a<3066 then A(x,m,a,s) else rr(x,m,a,s)
    let hhq(x:int, m:int, a:int, s:int)  = if m<1659 then jpj(x,m,a,s) elif x>1806 then lh(x,m,a,s) else ntr(x,m,a,s)

    let lv(x:int, m:int, a:int, s:int)  = if a<543 then znq(x,m,a,s) elif a<825 then A(x,m,a,s) elif x<3669 then R(x,m,a,s) else A(x,m,a,s)
    let bk(x:int, m:int, a:int, s:int)  = if s>659 then A(x,m,a,s) else vf(x,m,a,s)
    let sj(x:int, m:int, a:int, s:int)  = if x>1645 then R(x,m,a,s) elif a>3807 then nlm(x,m,a,s) else A(x,m,a,s)




    


    let xxd(x:int, m:int, a:int, s:int)  = if a<937 then cm(x,m,a,s) elif m<689 then A(x,m,a,s) else lcr(x,m,a,s)

    let bl(x:int, m:int, a:int, s:int)  = if x>1747 then A(x,m,a,s) else zvk(x,m,a,s)


    let tn(x:int, m:int, a:int, s:int)  = if a>3559 then lnp(x,m,a,s) elif m>860 then dj(x,m,a,s) elif x>2439 then xv(x,m,a,s) else ghz(x,m,a,s)
    let fxp(x:int, m:int, a:int, s:int)  = if x<3712 then ccp(x,m,a,s) elif s<904 then ss(x,m,a,s) else shj(x,m,a,s)
    let fq(x:int, m:int, a:int, s:int)  = if m>3473 then tp(x,m,a,s) elif m>3434 then A(x,m,a,s) elif s>1511 then A(x,m,a,s) else AeA(x,m,a,s)
    let kq(x:int, m:int, a:int, s:int)  = if m>3723 then R(x,m,a,s) elif a<811 then mt(x,m,a,s) else br(x,m,a,s)
    let cdr(x:int, m:int, a:int, s:int)  = if x>3527 then zd(x,m,a,s) else cb(x,m,a,s)

    let rk(x:int, m:int, a:int, s:int)  = if s>1884 then kq(x,m,a,s) elif m>3604 then lv(x,m,a,s) elif s>1153 then fq(x,m,a,s) else cdr(x,m,a,s)
    let jvk(x:int, m:int, a:int, s:int)  = if m>3317 then A(x,m,a,s) elif s>1927 then R(x,m,a,s) elif a>2952 then R(x,m,a,s) else szx(x,m,a,s)

    let mkc(x:int, m:int, a:int, s:int)  = if m<632 then dgt(x,m,a,s) elif m>995 then gb(x,m,a,s) elif s<2449 then R(x,m,a,s) else A(x,m,a,s)
    let gvr(x:int, m:int, a:int, s:int)  = if x<1627 then jlj(x,m,a,s) else R(x,m,a,s)
    let fn(x:int, m:int, a:int, s:int)  = if x<1616 then ck(x,m,a,s) elif x<1634 then R(x,m,a,s) else ReR(x,m,a,s)
    let sjv(x:int, m:int, a:int, s:int)  = if a<2806 then gvr(x,m,a,s) elif m<1615 then mkc(x,m,a,s) elif m>2717 then jvk(x,m,a,s) else fn(x,m,a,s)
    let hzb(x:int, m:int, a:int, s:int)  = if m<2387 then cg(x,m,a,s) else tt(x,m,a,s)
    let fdq(x:int, m:int, a:int, s:int)  = if a<2937 then R(x,m,a,s) elif m>1742 then A(x,m,a,s) elif m>699 then A(x,m,a,s) else R(x,m,a,s)

    let xm(x:int, m:int, a:int, s:int)  = if s<626 then fdq(x,m,a,s) elif a<2958 then xnx(x,m,a,s) elif s<1218 then R(x,m,a,s) else ReR(x,m,a,s)
    let qrl(x:int, m:int, a:int, s:int)  = if a>2765 then rkt(x,m,a,s) else cnz(x,m,a,s)
    let tb(x:int, m:int, a:int, s:int)  = if s<1696 then xm(x,m,a,s) elif x>1678 then qrl(x,m,a,s) elif x<1672 then rdg(x,m,a,s) else hzb(x,m,a,s)

    let qxn(x:int, m:int, a:int, s:int)  = if x>1698 then hhq(x,m,a,s) elif x<1660 then sjv(x,m,a,s) else tb(x,m,a,s)
    let bjc(x:int, m:int, a:int, s:int)  = if s>1024 then hnt(x,m,a,s) else R(x,m,a,s)
    let frn(x:int, m:int, a:int, s:int)  = if x<3485 then vfx(x,m,a,s) else vgj(x,m,a,s)

    let lff(x:int, m:int, a:int, s:int)  = if x>2601 then frn(x,m,a,s) elif m<3372 then mz(x,m,a,s) else bjc(x,m,a,s)
    let ft(x:int, m:int, a:int, s:int)  = if s<725 then rhl(x,m,a,s) else lff(x,m,a,s)



    let qxm(x:int, m:int, a:int, s:int)  = if s<2975 then mlh(x,m,a,s) elif m>1465 then lrh(x,m,a,s) else R(x,m,a,s)
 


    let cvn(x:int, m:int, a:int, s:int)  = if s<2271 then R(x,m,a,s) elif x>1760 then qx(x,m,a,s) else R(x,m,a,s)

    let lzt(x:int, m:int, a:int, s:int)  = if m>1509 then R(x,m,a,s) elif x>1505 then A(x,m,a,s) elif m<537 then R(x,m,a,s) else A(x,m,a,s)

    let fqr(x:int, m:int, a:int, s:int)  = if s>2475 then lzt(x,m,a,s) elif a>3662 then R(x,m,a,s) else ReR(x,m,a,s)

    let kp(x:int, m:int, a:int, s:int)  = if s<3254 then xcn(x,m,a,s) elif m<2368 then xcv(x,m,a,s) else A(x,m,a,s)


    let kqs(x:int, m:int, a:int, s:int)  = if x<1646 then R(x,m,a,s) elif a>3810 then tdp(x,m,a,s) elif m<776 then mrf(x,m,a,s) else A(x,m,a,s)

    let lbg(x:int, m:int, a:int, s:int)  = if x>1685 then fll(x,m,a,s) elif x<1633 then vm(x,m,a,s) elif s<2084 then R(x,m,a,s) else ReR(x,m,a,s)
    let nrd(x:int, m:int, a:int, s:int)  = if x>3246 then A(x,m,a,s) elif x>2349 then R(x,m,a,s) else smf(x,m,a,s)



    let qbp(x:int, m:int, a:int, s:int)  = if m<1961 then A(x,m,a,s) elif s<3848 then sp(x,m,a,s) elif m>2251 then R(x,m,a,s) else mfz(x,m,a,s)





    



    let lcf(x:int, m:int, a:int, s:int)  = if s>1018 then A(x,m,a,s) elif a>721 then R(x,m,a,s) else fmp(x,m,a,s)








    let tbx(x:int, m:int, a:int, s:int)  = if s>3338 then R(x,m,a,s) elif x>2728 then A(x,m,a,s) elif x<2208 then A(x,m,a,s) else R(x,m,a,s)
    let cjh(x:int, m:int, a:int, s:int)  = if m>3506 then A(x,m,a,s) elif m<3434 then A(x,m,a,s) else AeA(x,m,a,s)
    let tl(x:int, m:int, a:int, s:int)  = if x>2730 then qtf(x,m,a,s) else xxd(x,m,a,s)
    let qs(x:int, m:int, a:int, s:int)  = if a>2177 then A(x,m,a,s) elif a>1953 then R(x,m,a,s) elif a<1811 then A(x,m,a,s) else R(x,m,a,s)
    let vsh(x:int, m:int, a:int, s:int)  = if a>3395 then mf(x,m,a,s) else tg(x,m,a,s)

    let dg(x:int, m:int, a:int, s:int)  = if s<3005 then R(x,m,a,s) else A(x,m,a,s)

    let rjl(x:int, m:int, a:int, s:int)  = if s<1499 then A(x,m,a,s) elif a<517 then A(x,m,a,s) elif m>1643 then R(x,m,a,s) else ReR(x,m,a,s)
    let bdb(x:int, m:int, a:int, s:int)  = R(x,m,a,s) //if x>2480 then R(x,m,a,s) elif ReR(x,m,a,s)

    let ndl(x:int, m:int, a:int, s:int)  = if s>3705 then tr(x,m,a,s) elif a<3474 then zr(x,m,a,s) elif x<1760 then pl(x,m,a,s) else R(x,m,a,s)

    let hvr(x:int, m:int, a:int, s:int)  = if a<3425 then rf(x,m,a,s) elif s<3426 then bl(x,m,a,s) else ndl(x,m,a,s)

    let xl(x:int, m:int, a:int, s:int)  = if m<1669 then A(x,m,a,s) elif s>3278 then kdg(x,m,a,s) else pm(x,m,a,s)


    let tkl(x:int, m:int, a:int, s:int)  = if x>1688 then xl(x,m,a,s) elif m>1977 then sj(x,m,a,s) else kqs(x,m,a,s)
    let fkh(x:int, m:int, a:int, s:int)  = if a<3538 then hvr(x,m,a,s) else tkl(x,m,a,s)
    let ljp(x:int, m:int, a:int, s:int)  = if s>1134 then bzg(x,m,a,s) else kkq(x,m,a,s)
    let dl(x:int, m:int, a:int, s:int)  = if a<118 then R(x,m,a,s) elif a>235 then R(x,m,a,s) else dg(x,m,a,s)


    let pls(x:int, m:int, a:int, s:int)  = if m>2456 then A(x,m,a,s) elif s>426 then R(x,m,a,s) elif m>2194 then R(x,m,a,s) else A(x,m,a,s)
    let btt(x:int, m:int, a:int, s:int)  = if m<2603 then hg(x,m,a,s) elif a>189 then dct(x,m,a,s) else bhr(x,m,a,s)
    let dqk(x:int, m:int, a:int, s:int)  = if m>3212 then R(x,m,a,s) elif s>1016 then A(x,m,a,s) else pls(x,m,a,s)
    let ffc(x:int, m:int, a:int, s:int)  = if s>1660 then dl(x,m,a,s) elif x<1559 then dqk(x,m,a,s) elif x>1746 then mmg(x,m,a,s) else btt(x,m,a,s)


    let qqx(x:int, m:int, a:int, s:int)  = if x>3015 then qv(x,m,a,s) else pr(x,m,a,s)
    let jdc(x:int, m:int, a:int, s:int)  = if x>2745 then rjl(x,m,a,s) else A(x,m,a,s)

    let pb(x:int, m:int, a:int, s:int)  = if s<2328 then R(x,m,a,s) elif a<1018 then gl(x,m,a,s) elif m>3696 then bdx(x,m,a,s) else A(x,m,a,s)

    let ld(x:int, m:int, a:int, s:int)  = if x<2662 then kdb(x,m,a,s) elif x>2851 then A(x,m,a,s) elif m<3657 then gt(x,m,a,s) else A(x,m,a,s)
    let ks(x:int, m:int, a:int, s:int)  = if x>2852 then R(x,m,a,s) else zlt(x,m,a,s)

    let tqb(x:int, m:int, a:int, s:int)  = if x<2363 then pb(x,m,a,s) elif s>2261 then ld(x,m,a,s) else ks(x,m,a,s)

    let rhj(x:int, m:int, a:int, s:int)  = if s<3065 then A(x,m,a,s) elif m<3720 then cjh(x,m,a,s) else nv(x,m,a,s)

    let dr(x:int, m:int, a:int, s:int)  = if s<1876 then fxp(x,m,a,s) else rhj(x,m,a,s)

    let vkk(x:int, m:int, a:int, s:int)  = if m<3367 then qqx(x,m,a,s) elif x<3176 then tqb(x,m,a,s) elif a<1238 then rk(x,m,a,s) else dr(x,m,a,s)
    let qdp(x:int, m:int, a:int, s:int)  = if a<3818 then gzx(x,m,a,s) else A(x,m,a,s)

    let xvt(x:int, m:int, a:int, s:int)  = if a>3623 then nx(x,m,a,s) else A(x,m,a,s)

    let vq(x:int, m:int, a:int, s:int)  = if m<2151 then R(x,m,a,s) elif s>837 then A(x,m,a,s) else bm(x,m,a,s)
    let zbr(x:int, m:int, a:int, s:int)  = if a>3598 then qdp(x,m,a,s) else vsh(x,m,a,s)

    let xb(x:int, m:int, a:int, s:int)  = if x<1323 then kdz(x,m,a,s) elif s<2020 then A(x,m,a,s) else mvt(x,m,a,s)
    let vr(x:int, m:int, a:int, s:int)  = if a<3735 then qdr(x,m,a,s) elif x>1746 then dst(x,m,a,s) elif s<1998 then pjn(x,m,a,s) else A(x,m,a,s)
    let thr(x:int, m:int, a:int, s:int)  = if a<3473 then fdt(x,m,a,s) elif s<2291 then px(x,m,a,s) elif x>1738 then qn(x,m,a,s) else A(x,m,a,s)
    let vvs(x:int, m:int, a:int, s:int)  = if m<1832 then gst(x,m,a,s) elif x>1728 then xkp(x,m,a,s) elif x>1651 then zgj(x,m,a,s) else R(x,m,a,s)

    let pp(x:int, m:int, a:int, s:int)  = if m>2274 then mrc(x,m,a,s) elif m<1108 then lbg(x,m,a,s) elif m>1498 then vvs(x,m,a,s) else thr(x,m,a,s)

    let lk(x:int, m:int, a:int, s:int)  = if a>3868 then cvn(x,m,a,s) else vr(x,m,a,s)
    let jz(x:int, m:int, a:int, s:int)  = if a<3613 then pp(x,m,a,s) else lk(x,m,a,s)



    let vl(x:int, m:int, a:int, s:int)  = if s<2867 then R(x,m,a,s) elif x<3226 then tbx(x,m,a,s) elif m<143 then fsj(x,m,a,s) else A(x,m,a,s)



    let tk(x:int, m:int, a:int, s:int)  = if a>1095 then fsb(x,m,a,s) else R(x,m,a,s)
    let tz(x:int, m:int, a:int, s:int)  = if x>2729 then A(x,m,a,s) elif a>1540 then A(x,m,a,s) elif x<2269 then ttv(x,m,a,s) else tkd(x,m,a,s)

    let nhl(x:int, m:int, a:int, s:int)  = if a<842 then jdc(x,m,a,s) elif m>1845 then vq(x,m,a,s) elif a<1264 then tk(x,m,a,s) else tz(x,m,a,s)


    let fgc(x:int, m:int, a:int, s:int)  = if x<1525 then fqr(x,m,a,s) else fdf(x,m,a,s)

    let kc(x:int, m:int, a:int, s:int)  = if m>2340 then hrv(x,m,a,s) elif s>1715 then A(x,m,a,s) else R(x,m,a,s)

    let vxx(x:int, m:int, a:int, s:int)  = if x>1390 then xvt(x,m,a,s) elif a<3702 then kc(x,m,a,s) else xb(x,m,a,s)
    let mkg(x:int, m:int, a:int, s:int)  = if x>1475 then fgc(x,m,a,s) else vxx(x,m,a,s)

    



    let np(x:int, m:int, a:int, s:int)  = if x>1370 then lcf(x,m,a,s) else bk(x,m,a,s)


    let rvf(x:int, m:int, a:int, s:int)  = if m<3175 then R(x,m,a,s) elif m<3678 then gg(x,m,a,s) else dk(x,m,a,s)

    let hb(x:int, m:int, a:int, s:int)  = if x<3265 then A(x,m,a,s) elif m<2201 then A(x,m,a,s) elif s>3582 then A(x,m,a,s) else lc(x,m,a,s)

    let kfq(x:int, m:int, a:int, s:int)  = if m>3404 then R(x,m,a,s) elif m>3071 then A(x,m,a,s) else nh(x,m,a,s)


    let ds(x:int, m:int, a:int, s:int)  = if s>2587 then rvf(x,m,a,s) else kfq(x,m,a,s)




    let tv(x:int, m:int, a:int, s:int)  = if a>3495 then tqs(x,m,a,s) elif m<1901 then A(x,m,a,s) else zck(x,m,a,s)




    let qrv(x:int, m:int, a:int, s:int)  = if s<2662 then cnk(x,m,a,s) elif s>3212 then A(x,m,a,s) elif m<2188 then R(x,m,a,s) else A(x,m,a,s)

    

    let dm(x:int, m:int, a:int, s:int)  = if a<3662 then rz(x,m,a,s) elif x<1113 then R(x,m,a,s) elif x>1142 then xtp(x,m,a,s) else xlf(x,m,a,s)
    let zj(x:int, m:int, a:int, s:int)  = if m>1037 then A(x,m,a,s) elif m>471 then dsf(x,m,a,s) elif x>3609 then R(x,m,a,s) else rm(x,m,a,s)
    let mm(x:int, m:int, a:int, s:int)  = if a>2237 then kv(x,m,a,s) elif x>2878 then sc(x,m,a,s) elif m<1672 then mhg(x,m,a,s) else qp(x,m,a,s)

    let cr(x:int, m:int, a:int, s:int)  = if a<1904 then R(x,m,a,s) elif m>976 then A(x,m,a,s) elif s>3736 then R(x,m,a,s) else ReR(x,m,a,s)

    let ml(x:int, m:int, a:int, s:int)  = if s<3209 then dzn(x,m,a,s) else cr(x,m,a,s)
    let zf(x:int, m:int, a:int, s:int)  = if x<2559 then R(x,m,a,s) elif a<3507 then bg(x,m,a,s) elif a>3813 then A(x,m,a,s) else xsf(x,m,a,s)
    let dgd(x:int, m:int, a:int, s:int)  = if m<919 then xs(x,m,a,s) elif x>3141 then ph(x,m,a,s) else R(x,m,a,s)
    let nn(x:int, m:int, a:int, s:int)  = if a<2837 then mm(x,m,a,s) elif x>3088 then zj(x,m,a,s) elif m>1332 then zf(x,m,a,s) else tn(x,m,a,s)

    let jm(x:int, m:int, a:int, s:int)  = if s>3456 then A(x,m,a,s) elif s>2930 then A(x,m,a,s) elif x>2786 then ms(x,m,a,s) else R(x,m,a,s)

    let vlj(x:int, m:int, a:int, s:int)  = if a<2140 then ml(x,m,a,s) elif a>2383 then dgd(x,m,a,s) else jm(x,m,a,s)
    let dlf(x:int, m:int, a:int, s:int)  = if x>3210 then dcg(x,m,a,s) else pqm(x,m,a,s)

    let hq(x:int, m:int, a:int, s:int)  = if s>3232 then qs(x,m,a,s) elif m>2220 then jt(x,m,a,s) elif a>2077 then A(x,m,a,s) else R(x,m,a,s)

    let rkm(x:int, m:int, a:int, s:int)  = if x<2920 then qpl(x,m,a,s) else hq(x,m,a,s)
    let bh(x:int, m:int, a:int, s:int)  = if s<2666 then nn(x,m,a,s) elif a>2622 then dlf(x,m,a,s) elif m<1714 then vlj(x,m,a,s) else rkm(x,m,a,s)
    let hd(x:int, m:int, a:int, s:int)  = if x<1703 then bbm(x,m,a,s) elif m>3786 then cbq(x,m,a,s) elif m<3748 then R(x,m,a,s) else ReR(x,m,a,s)
    let zdt(x:int, m:int, a:int, s:int)  = if m<3707 then vtk(x,m,a,s) elif m>3837 then fsz(x,m,a,s) else hd(x,m,a,s)


    let lr(x:int, m:int, a:int, s:int)  = if m<2420 then crv(x,m,a,s) elif s>569 then zbr(x,m,a,s) elif m<3184 then sth(x,m,a,s) else zdt(x,m,a,s)
    let hh(x:int, m:int, a:int, s:int)  = if a<3215 then qxn(x,m,a,s) elif s<1521 then lr(x,m,a,s) elif s<2817 then jz(x,m,a,s) else fkh(x,m,a,s)




    let jb(x:int, m:int, a:int, s:int)  = if x<1581 then pmf(x,m,a,s) elif m>2361 then A(x,m,a,s) else R(x,m,a,s)
    let rn(x:int, m:int, a:int, s:int)  = if m<2545 then R(x,m,a,s) elif a<457 then R(x,m,a,s) elif a>540 then R(x,m,a,s) else tfz(x,m,a,s)
    let lg(x:int, m:int, a:int, s:int)  = if s<901 then jb(x,m,a,s) elif s>1546 then rn(x,m,a,s) elif a>482 then fd(x,m,a,s) else ljp(x,m,a,s)

    let xz(x:int, m:int, a:int, s:int)  = if m<1481 then cps(x,m,a,s) elif a>972 then lcp(x,m,a,s) elif s<3564 then A(x,m,a,s) else mn(x,m,a,s)



    let hzq(x:int, m:int, a:int, s:int)  = if s<705 then A(x,m,a,s) elif a<3489 then A(x,m,a,s) else AeA(x,m,a,s)
    let jbq(x:int, m:int, a:int, s:int)  = if m>1513 then A(x,m,a,s) elif s<563 then A(x,m,a,s) else hzq(x,m,a,s)
    let vfz(x:int, m:int, a:int, s:int)  = if a<3535 then tpv(x,m,a,s) else R(x,m,a,s)
    let fvx(x:int, m:int, a:int, s:int)  = if s>864 then dm(x,m,a,s) elif x>1121 then jbq(x,m,a,s) else vfz(x,m,a,s)


    let pbp(x:int, m:int, a:int, s:int)  = if m<220 then sf(x,m,a,s) elif m>275 then bdb(x,m,a,s) elif s<889 then R(x,m,a,s) else A(x,m,a,s)

    let hx(x:int, m:int, a:int, s:int)  = if s>2045 then vl(x,m,a,s) elif x>3142 then lvj(x,m,a,s) else pbp(x,m,a,s)

    let gqp(x:int, m:int, a:int, s:int)  = if a<3558 then xcj(x,m,a,s) elif s<462 then R(x,m,a,s) elif s>988 then R(x,m,a,s) else ReR(x,m,a,s)

    let dz(x:int, m:int, a:int, s:int)  = if a<713 then nrd(x,m,a,s) else qbp(x,m,a,s)

    let bd(x:int, m:int, a:int, s:int)  = if m<353 then hx(x,m,a,s) else tl(x,m,a,s)
    let lnn(x:int, m:int, a:int, s:int)  = if a<3317 then ds(x,m,a,s) else lzz(x,m,a,s)
    let dtt(x:int, m:int, a:int, s:int)  = if m>1833 then hb(x,m,a,s) else xz(x,m,a,s)
    let qm(x:int, m:int, a:int, s:int)  = if s<2346 then nhl(x,m,a,s) elif s<3437 then dq(x,m,a,s) elif s<3753 then dtt(x,m,a,s) else dz(x,m,a,s)
    let ffn(x:int, m:int, a:int, s:int)  = if a<2017 then vkk(x,m,a,s) elif s<1515 then ft(x,m,a,s) else lnn(x,m,a,s)
    let rq(x:int, m:int, a:int, s:int)  = if a>1733 then bh(x,m,a,s) elif m>996 then qm(x,m,a,s) else bd(x,m,a,s)
    let jfl(x:int, m:int, a:int, s:int)  = if a>629 then qxm(x,m,a,s) elif x<1525 then kp(x,m,a,s) elif a>532 then ksl(x,m,a,s) else qrv(x,m,a,s)
    let vk(x:int, m:int, a:int, s:int)  = if s>1922 then jfl(x,m,a,s) elif a<588 then lg(x,m,a,s) else np(x,m,a,s)
    let dnq(x:int, m:int, a:int, s:int)  = if m>1899 then ffc(x,m,a,s) else sb(x,m,a,s)
    let xxv(x:int, m:int, a:int, s:int)  = if a>872 then vn(x,m,a,s) elif a>348 then vk(x,m,a,s) else dnq(x,m,a,s)
    let xq(x:int, m:int, a:int, s:int)  = if m>2576 then ffn(x,m,a,s) else rq(x,m,a,s)
    let tvj(x:int, m:int, a:int, s:int)  = if s<1336 then gqp(x,m,a,s) else tv(x,m,a,s)
    let hgz(x:int, m:int, a:int, s:int)  = if x>1160 then tvj(x,m,a,s) elif s<1847 then fvx(x,m,a,s) else ccn(x,m,a,s)
    let gms(x:int, m:int, a:int, s:int)  = if a<3153 then tbr(x,m,a,s) elif x<1274 then hgz(x,m,a,s) else mkg(x,m,a,s)
    let gx(x:int, m:int, a:int, s:int)  = if x<1056 then jf(x,m,a,s) elif a<2531 then xxv(x,m,a,s) elif x>1588 then hh(x,m,a,s) else gms(x,m,a,s)

    let in2(x:int, m:int, a:int, s:int)  = if x>1863 then xq(x,m,a,s) else gx(x,m,a,s)

    let parse (input:string) =
        let p = input.Replace("{x=","").Replace(",m=",",").Replace(",a=",",").Replace(",s=",",").Replace("}","").Split ','
        (int p[0], int p[1], int p[2], int p[3])


    let countAccepted(input:seq<string>, f) =
        input
        |> Seq.map parse
        |> Seq.iter (fun (x,m,a,s) -> f(x,m,a,s))

        accepted

    let count(input:seq<string>) =
        countAccepted (input, in2)