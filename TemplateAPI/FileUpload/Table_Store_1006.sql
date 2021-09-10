USE [EduPan]
GO
/****** Object:  StoredProcedure [dbo].[sp_Urcheck_delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Urcheck_delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Urcheck_delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Urcheck]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Urcheck]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Urcheck]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_UpdatePassword]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_UpdatePassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_UpdatePassword]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_UpdateInfo]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_UpdateInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_UpdateInfo]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Login]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Login]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Login]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_ChangePassword]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_ChangePassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_ChangePassword]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduVeMoi_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduVeMoi_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduVeMoi_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduVeMoi_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduVeMoi_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduVeMoi_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduVeMoi_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduVeMoi_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_PhuongPhapNC_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_PhuongPhapNC_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_PhuongPhapNC_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_PhuongPhapNC_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_PhuongPhapNC_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_PhuongPhapNC_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_CongTrinhNC_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_CongTrinhNC_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_CongTrinhNC_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_CongTrinhNC_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTruongHoc_CongTrinhNC_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTrungTam_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTrungTam_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTrungTam_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTrungTam_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTrungTam_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTrungTam_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTrungTam_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTrungTam_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTaiLieuHoiThao_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTaiLieuHoiThao_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTaiLieuHoiThao_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTaiLieuHoiThao_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTaiLieuHoiThao_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTaiLieuHoiThao_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduTaiLieuHoiThao_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduTaiLieuHoiThao_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduSinhVien_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduSinhVien_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduSinhVien_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduSinhVien_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduSinhVien_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduSinhVien_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduSinhVien_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduSinhVien_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhuongPhapNghienCuu_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhuongPhapNghienCuu_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhuongPhapNghienCuu_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhuongPhapNghienCuu_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhuongPhapNghienCuu_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhuongPhapNghienCuu_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhuongPhapNghienCuu_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhuongPhapNghienCuu_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhongHop_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhongHop_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhongHop_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhongHop_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhongHop_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhongHop_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduPhongHop_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduPhongHop_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiVeMoi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiVeMoi_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiVeMoi_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHoTro_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiHoTro_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiHoTro_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiHocBong_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiHocBong_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiHocBong_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiHocBong_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiHocBong_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiHocBong_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduLoaiHocBong_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduLoaiHocBong_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHoiThao_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHoiThao_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHoiThao_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHoiThao_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHoiThao_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHoiThao_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHoiThao_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHoiThao_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocVi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHocVi_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHocVi_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocHam_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHocHam_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHocHam_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocBongSinhVien_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduHocBongSinhVien_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduHocBongSinhVien_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduDiaPhuong_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduDiaPhuong_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduDiaPhuong_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduDiaPhuong_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduDiaPhuong_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduDiaPhuong_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduDiaPhuong_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduDiaPhuong_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduCongTrinhNghienCuu_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduCongTrinhNghienCuu_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduCongTrinhNghienCuu_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduCongTrinhNghienCuu_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduCongTrinhNghienCuu_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduCongTrinhNghienCuu_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduCongTrinhNghienCuu_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduCongTrinhNghienCuu_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGiaPhongHop_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGiaPhongHop_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGiaPhongHop_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGiaPhongHop_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGiaPhongHop_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGiaPhongHop_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_UPDATE]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGia_UPDATE]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGia_UPDATE]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGia_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGia_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGia_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGia_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_eduChuyenGia_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_eduChuyenGia_Delete]
GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocBongSinhVien_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduHocBongSinhVien_Update]
GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocBongSinhVien_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduHocBongSinhVien_Insert]
GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocBongSinhVien_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduHocBongSinhVien_Delete]
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDanhSachHoTro_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduDanhSachHoTro_Update]
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDanhSachHoTro_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduDanhSachHoTro_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_INSERT]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDanhSachHoTro_INSERT]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduDanhSachHoTro_INSERT]
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDanhSachHoTro_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[eduDanhSachHoTro_Delete]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_htUsers_Active]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[htUsers] DROP CONSTRAINT [DF_htUsers_Active]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_htUsers_Admin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[htUsers] DROP CONSTRAINT [DF_htUsers_Admin]
END
GO
/****** Object:  Table [dbo].[htUsers]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[htUsers]') AND type in (N'U'))
DROP TABLE [dbo].[htUsers]
GO
/****** Object:  Table [dbo].[eduVeMoi]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduVeMoi]') AND type in (N'U'))
DROP TABLE [dbo].[eduVeMoi]
GO
/****** Object:  Table [dbo].[eduTruongHoc_PhuongPhapNC]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduTruongHoc_PhuongPhapNC]') AND type in (N'U'))
DROP TABLE [dbo].[eduTruongHoc_PhuongPhapNC]
GO
/****** Object:  Table [dbo].[eduTruongHoc_CongTrinhNC]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduTruongHoc_CongTrinhNC]') AND type in (N'U'))
DROP TABLE [dbo].[eduTruongHoc_CongTrinhNC]
GO
/****** Object:  Table [dbo].[eduTruongHoc]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduTruongHoc]') AND type in (N'U'))
DROP TABLE [dbo].[eduTruongHoc]
GO
/****** Object:  Table [dbo].[eduTrungTam]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduTrungTam]') AND type in (N'U'))
DROP TABLE [dbo].[eduTrungTam]
GO
/****** Object:  Table [dbo].[eduTaiLieuHoiThao]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduTaiLieuHoiThao]') AND type in (N'U'))
DROP TABLE [dbo].[eduTaiLieuHoiThao]
GO
/****** Object:  Table [dbo].[eduSinhVien]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduSinhVien]') AND type in (N'U'))
DROP TABLE [dbo].[eduSinhVien]
GO
/****** Object:  Table [dbo].[eduPhuongPhapNghienCuu]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduPhuongPhapNghienCuu]') AND type in (N'U'))
DROP TABLE [dbo].[eduPhuongPhapNghienCuu]
GO
/****** Object:  Table [dbo].[eduPhongHop]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduPhongHop]') AND type in (N'U'))
DROP TABLE [dbo].[eduPhongHop]
GO
/****** Object:  Table [dbo].[eduLoaiVeMoi]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduLoaiVeMoi]') AND type in (N'U'))
DROP TABLE [dbo].[eduLoaiVeMoi]
GO
/****** Object:  Table [dbo].[eduLoaiHoTro]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduLoaiHoTro]') AND type in (N'U'))
DROP TABLE [dbo].[eduLoaiHoTro]
GO
/****** Object:  Table [dbo].[eduLoaiHocBong]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduLoaiHocBong]') AND type in (N'U'))
DROP TABLE [dbo].[eduLoaiHocBong]
GO
/****** Object:  Table [dbo].[eduHoiThao]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHoiThao]') AND type in (N'U'))
DROP TABLE [dbo].[eduHoiThao]
GO
/****** Object:  Table [dbo].[eduHocVi]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocVi]') AND type in (N'U'))
DROP TABLE [dbo].[eduHocVi]
GO
/****** Object:  Table [dbo].[eduHocHam]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocHam]') AND type in (N'U'))
DROP TABLE [dbo].[eduHocHam]
GO
/****** Object:  Table [dbo].[eduHocBongSinhVien]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduHocBongSinhVien]') AND type in (N'U'))
DROP TABLE [dbo].[eduHocBongSinhVien]
GO
/****** Object:  Table [dbo].[eduDiaPhuong]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDiaPhuong]') AND type in (N'U'))
DROP TABLE [dbo].[eduDiaPhuong]
GO
/****** Object:  Table [dbo].[eduDanhSachHoTro]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduDanhSachHoTro]') AND type in (N'U'))
DROP TABLE [dbo].[eduDanhSachHoTro]
GO
/****** Object:  Table [dbo].[eduCongTrinhNghienCuu]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduCongTrinhNghienCuu]') AND type in (N'U'))
DROP TABLE [dbo].[eduCongTrinhNghienCuu]
GO
/****** Object:  Table [dbo].[eduChuyenGiaPhongHop]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduChuyenGiaPhongHop]') AND type in (N'U'))
DROP TABLE [dbo].[eduChuyenGiaPhongHop]
GO
/****** Object:  Table [dbo].[eduChuyenGia]    Script Date: 8/25/2021 7:18:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[eduChuyenGia]') AND type in (N'U'))
DROP TABLE [dbo].[eduChuyenGia]
GO
/****** Object:  Table [dbo].[eduChuyenGia]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduChuyenGia](
	[ID_chuyen_gia] [int] IDENTITY(1,1) NOT NULL,
	[ID_hoc_ham] [int] NULL,
	[ID_hoc_vi] [int] NULL,
	[Gioi_tinh] [bit] NULL,
	[Ngay_sinh] [date] NULL,
	[ID_phuong_phap] [int] NULL,
	[ID_cong_trinh] [int] NULL,
	[Ten_chuyen_gia] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_chuyen_gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduChuyenGiaPhongHop]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduChuyenGiaPhongHop](
	[ID_cg_ph] [int] IDENTITY(1,1) NOT NULL,
	[ID_phong_hop] [int] NULL,
	[ID_chuyen_gia] [int] NULL,
	[Hang] [int] NULL,
	[Cot] [int] NULL,
	[Trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_cg_ph] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduCongTrinhNghienCuu]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduCongTrinhNghienCuu](
	[ID_cong_trinh] [int] IDENTITY(1,1) NOT NULL,
	[Ten_cong_trinh] [nvarchar](max) NULL,
	[Ngay_tao] [date] NULL,
	[Trang_thai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_cong_trinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduDanhSachHoTro]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduDanhSachHoTro](
	[ID_ho_tro] [int] IDENTITY(1,1) NOT NULL,
	[ID_loai] [int] NULL,
	[ID_dia_phuong] [int] NULL,
	[So_luong] [int] NULL,
	[Trang_thai_duyet] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ho_tro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduDiaPhuong]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduDiaPhuong](
	[ID_dia_phuong] [int] IDENTITY(1,1) NOT NULL,
	[Ma_dia_phuong] [nvarchar](50) NULL,
	[Ten_dia_phuong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_dia_phuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduHocBongSinhVien]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduHocBongSinhVien](
	[ID_hb_sv] [int] IDENTITY(1,1) NOT NULL,
	[ID_loai] [int] NULL,
	[Ten_hoc_bong] [nvarchar](max) NULL,
	[Ngay_cap] [date] NULL,
	[Trang_thai] [int] NULL,
	[ID_sinh_vien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_hb_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduHocHam]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduHocHam](
	[ID_hoc_ham] [int] IDENTITY(1,1) NOT NULL,
	[Ten_hoc_ham] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_hoc_ham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduHocVi]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduHocVi](
	[ID_hoc_vi] [int] IDENTITY(1,1) NOT NULL,
	[Ten_hoc_vi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_hoc_vi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduHoiThao]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduHoiThao](
	[ID_hoi_thao] [int] IDENTITY(1,1) NOT NULL,
	[Ten_hoi_thao] [nvarchar](max) NULL,
	[Ngay_bat_dau] [date] NULL,
	[Ngay_ket_thuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_hoi_thao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduLoaiHocBong]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduLoaiHocBong](
	[ID_loai_hoc_bong] [int] IDENTITY(1,1) NOT NULL,
	[Ten_loai_hoc_bong] [nvarchar](50) NULL,
	[Gia_tri] [decimal](18, 0) NULL,
	[Nam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_loai_hoc_bong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduLoaiHoTro]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduLoaiHoTro](
	[ID_loai] [int] IDENTITY(1,1) NOT NULL,
	[Ten_loai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduLoaiVeMoi]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduLoaiVeMoi](
	[ID_loai] [int] IDENTITY(1,1) NOT NULL,
	[Ten_loai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduPhongHop]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduPhongHop](
	[ID_phong_hop] [int] IDENTITY(1,1) NOT NULL,
	[Ma_phong] [nvarchar](10) NULL,
	[Ten_phong] [nvarchar](50) NULL,
	[Suc_chua] [int] NULL,
	[So_hang] [int] NULL,
	[So_cot] [int] NULL,
	[ID_hoi_thao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_phong_hop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduPhuongPhapNghienCuu]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduPhuongPhapNghienCuu](
	[ID_phuong_phap] [int] IDENTITY(1,1) NOT NULL,
	[Ten_phuong_phap] [nvarchar](50) NULL,
	[Ngay_tao] [date] NULL,
	[Trang_thai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_phuong_phap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduSinhVien]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduSinhVien](
	[ID_sinh_vien] [int] IDENTITY(1,1) NOT NULL,
	[Ho_ten] [nvarchar](50) NULL,
	[Dia_chi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[So_dien_thoai] [nvarchar](50) NULL,
	[CCCD] [nvarchar](20) NULL,
	[Gioi_tinh] [bit] NULL,
	[Ngay_sinh] [date] NULL,
	[ID_truong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_sinh_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduTaiLieuHoiThao]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduTaiLieuHoiThao](
	[ID_tai_lieu] [int] IDENTITY(1,1) NOT NULL,
	[Ten_tai_lieu] [nvarchar](50) NULL,
	[Mo_ta] [nvarchar](max) NULL,
	[ID_hoi_thao] [int] NULL,
	[FileName] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[DocType] [nvarchar](max) NULL,
	[FileDoc] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_tai_lieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduTrungTam]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduTrungTam](
	[ID_trung_tam] [int] IDENTITY(1,1) NOT NULL,
	[Ma_trung_tam] [nvarchar](50) NULL,
	[Ten_trung_tam] [nvarchar](50) NULL,
	[Dia_chi] [nvarchar](50) NULL,
	[So_dien_thoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_trung_tam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduTruongHoc]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduTruongHoc](
	[ID_truong] [int] IDENTITY(1,1) NOT NULL,
	[Ma_truong] [nvarchar](50) NULL,
	[Ten_truong] [nvarchar](50) NULL,
	[Dia_chi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_truong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduTruongHoc_CongTrinhNC]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduTruongHoc_CongTrinhNC](
	[ID_th_ct] [int] IDENTITY(1,1) NOT NULL,
	[ID_cong_trinh] [int] NULL,
	[ID_truong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_th_ct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduTruongHoc_PhuongPhapNC]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduTruongHoc_PhuongPhapNC](
	[ID_th_pp] [int] IDENTITY(1,1) NOT NULL,
	[ID_phuong_phap] [int] NULL,
	[ID_truong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_th_pp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eduVeMoi]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eduVeMoi](
	[ID_ve_moi] [int] IDENTITY(1,1) NOT NULL,
	[Ten_ve] [nvarchar](50) NULL,
	[Ngay_bat_dau] [date] NULL,
	[Ngay_ket_thuc] [date] NULL,
	[ID_loai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ve_moi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[htUsers]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[htUsers](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Admin] [bit] NULL,
	[Active] [bit] NULL,
	[Email] [nvarchar](200) NULL,
 CONSTRAINT [PK_htUsers] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[htUsers] ADD  CONSTRAINT [DF_htUsers_Admin]  DEFAULT ((0)) FOR [Admin]
GO
ALTER TABLE [dbo].[htUsers] ADD  CONSTRAINT [DF_htUsers_Active]  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduDanhSachHoTro_Delete]
	@ID_ho_tro INT
AS
	DELETE FROM eduDanhSachHoTro WHERE ID_ho_tro = @ID_ho_tro
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_INSERT]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduDanhSachHoTro_INSERT]
	@ID_loai INT,
	@ID_dia_phuong INT,
	@So_luong INT,
	@Trang_thai_duyet BIT
AS
	INSERT INTO eduDanhSachHoTro(ID_loai,ID_dia_phuong,So_luong,Trang_thai_duyet)
		VALUES(@ID_loai,@ID_dia_phuong,@So_luong,@Trang_thai_duyet)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduDanhSachHoTro_Load_List]
AS
	SELECT ht.*,dp.Ten_dia_phuong,loai.Ten_loai
	FROM eduDanhSachHoTro ht
	INNER JOIN eduDiaPhuong dp
	ON ht.ID_dia_phuong = dp.ID_dia_phuong
	INNER JOIN eduLoaiHoTro loai
	ON ht.ID_loai = loai.ID_loai
GO
/****** Object:  StoredProcedure [dbo].[eduDanhSachHoTro_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduDanhSachHoTro_Update]
	@ID_ho_tro INT,
	@ID_loai INT,
	@ID_dia_phuong INT,
	@So_luong INT,
	@Trang_thai_duyet BIT
AS
	UPDATE eduDanhSachHoTro SET
	ID_loai = @ID_loai,
	ID_dia_phuong = @ID_dia_phuong,
	So_luong = @So_luong,
	Trang_thai_duyet = @Trang_thai_duyet
	WHERE ID_ho_tro = @ID_ho_tro
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE 
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduHocBongSinhVien_Delete]
	@ID_hb_sv INT
AS
	DELETE FROM eduHocBongSinhVien WHERE ID_hb_sv = @ID_hb_sv
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted

GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduHocBongSinhVien_Insert]
	@ID_loai INT,
	@Ten_hoc_bong NVARCHAR(MAX),
	@Ngay_cap DATE,
	@Trang_thai INT,
	@ID_sinh_vien INT
AS
	INSERT INTO eduHocBongSinhVien(ID_loai,Ten_hoc_bong,Ngay_cap,Trang_thai,ID_sinh_vien)
	VALUES(@ID_loai,@Ten_hoc_bong,@Ngay_cap,@Trang_thai,@ID_sinh_vien)
	SELECT @@IDENTITY AS 'Identity'

GO
/****** Object:  StoredProcedure [dbo].[eduHocBongSinhVien_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eduHocBongSinhVien_Update]
	@ID_hb_sv INT,
	@ID_loai INT,
	@Ten_hoc_bong NVARCHAR(MAX),
	@Ngay_cap DATE,
	@Trang_thai INT,
	@ID_sinh_vien INT
AS
	UPDATE eduHocBongSinhVien SET
	ID_loai = @ID_loai,
	Ten_hoc_bong = @Ten_hoc_bong,
	Ngay_cap = @Ngay_cap,
	Trang_thai = @Trang_thai,
	ID_sinh_vien = @ID_sinh_vien
	WHERE ID_hb_sv = @ID_hb_sv
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated

GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGia_Delete]
@ID_chuyen_gia INT
AS
DELETE FROM eduChuyenGia WHERE ID_chuyen_gia = @ID_chuyen_gia
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGia_Insert]
	@Ten_chuyen_gia NVARCHAR(50),
	@ID_hoc_ham INT,
	@ID_hoc_vi INT,
	@Gioi_tinh BIT,
	@Ngay_sinh DATE,
	@ID_phuong_phap INT,
	@ID_cong_trinh INT
AS
INSERT INTO eduChuyenGia(Ten_chuyen_gia,ID_hoc_ham,ID_hoc_vi,Gioi_tinh,Ngay_sinh,ID_phuong_phap,ID_cong_trinh)
	VALUES(@Ten_chuyen_gia,@ID_hoc_ham,@ID_hoc_vi,@Gioi_tinh,@Ngay_sinh,@ID_phuong_phap,@ID_cong_trinh)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGia_Load_List]
AS
SELECT cg.*,pp.Ten_phuong_phap,ct.Ten_cong_trinh,hh.Ten_hoc_ham,hv.Ten_hoc_vi,cgph.Trang_thai
FROM eduChuyenGia cg
LEFT JOIN eduPhuongPhapNghienCuu pp
ON cg.ID_phuong_phap = pp.ID_phuong_phap
LEFT JOIN eduCongTrinhNghienCuu ct
ON cg.ID_cong_trinh = ct.ID_cong_trinh
LEFT JOIN eduHocHam hh
ON cg.ID_hoc_ham = hh.ID_hoc_ham
LEFT JOIN eduHocVi hv
ON cg.ID_hoc_vi = hv.ID_hoc_vi
LEFT JOIN eduChuyenGiaPhongHop cgph
ON cg.ID_chuyen_gia = cgph.ID_chuyen_gia

GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGia_UPDATE]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGia_UPDATE]
	@Ten_chuyen_gia NVARCHAR(50),
	@ID_chuyen_gia INT,
	@ID_hoc_ham INT,
	@ID_hoc_vi INT,
	@Gioi_tinh BIT,
	@Ngay_sinh DATE,
	@ID_phuong_phap INT,
	@ID_cong_trinh INT
AS
UPDATE eduChuyenGia SET 
	Ten_chuyen_gia = @Ten_chuyen_gia,
	ID_hoc_ham = @ID_hoc_ham,
	ID_hoc_vi = @ID_hoc_vi,
	Gioi_tinh = @Gioi_tinh,
	Ngay_sinh = @Ngay_sinh, 
	ID_phuong_phap = @ID_phuong_phap,
	ID_cong_trinh = @ID_cong_trinh
WHERE 
	ID_chuyen_gia = @ID_chuyen_gia
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGiaPhongHop_Delete]
	@ID_cg_ph INT
AS
	DELETE FROM eduChuyenGiaPhongHop WHERE ID_cg_ph = @ID_cg_ph
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGiaPhongHop_Insert]
	@ID_phong_hop INT,
	@ID_chuyen_gia INT,
	@Hang INT,
	@Cot INT,
	@Trang_thai BIT
AS
	INSERT INTO eduChuyenGiaPhongHop(ID_phong_hop,ID_chuyen_gia,Hang,Cot,Trang_thai)
	VALUES(@ID_phong_hop,@ID_chuyen_gia,@Hang,@Cot,@Trang_thai)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduChuyenGiaPhongHop_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduChuyenGiaPhongHop_Load_List]
AS
SELECT cgph.*,cg.Ten_chuyen_gia,ph.Ten_phong
FROM eduChuyenGiaPhongHop cgph
INNER JOIN eduChuyenGia cg
ON cgph.ID_chuyen_gia = cg.ID_chuyen_gia
INNER JOIN eduPhongHop ph
ON cgph.ID_phong_hop = ph.ID_phong_hop
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduCongTrinhNghienCuu_Delete]
@ID_cong_trinh INT
AS
	DELETE FROM eduCongTrinhNghienCuu WHERE ID_cong_trinh = @ID_cong_trinh
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduCongTrinhNghienCuu_Insert]
	@Ten_cong_trinh NVARCHAR(MAX),
	@Ngay_tao DATE,
	@Trang_thai INT
AS
	INSERT INTO eduCongTrinhNghienCuu(Ten_cong_trinh,Ngay_tao,Trang_thai)
		VALUES(@Ten_cong_trinh,@Ngay_tao,@Trang_thai)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_eduCongTrinhNghienCuu_Load_List]
AS
SELECT * FROM eduCongTrinhNghienCuu
GO
/****** Object:  StoredProcedure [dbo].[sp_eduCongTrinhNghienCuu_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduCongTrinhNghienCuu_Update]
	@ID_cong_trinh INT,
	@Ten_cong_trinh NVARCHAR(MAX),
	@Ngay_tao DATE,
	@Trang_thai INT
AS
	UPDATE eduCongTrinhNghienCuu SET
	Ten_cong_trinh = @Ten_cong_trinh,
	Ngay_tao = @Ngay_tao, 
	Trang_thai = @Trang_thai
WHERE 
	ID_cong_trinh = @ID_cong_trinh
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduDiaPhuong_Delete]
	@ID_dia_phuong INT
AS
	DELETE FROM eduDiaPhuong WHERE ID_dia_phuong = @ID_dia_phuong
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduDiaPhuong_Insert]
	@Ma_dia_phuong NVARCHAR(50),
	@Ten_dia_phuong NVARCHAR(50)
AS
	INSERT INTO eduDiaPhuong(Ma_dia_phuong,Ten_dia_phuong)
	VALUES(@Ma_dia_phuong,@Ten_dia_phuong)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduDiaPhuong_Load_List]
AS
SELECT * FROM eduDiaPhuong
GO
/****** Object:  StoredProcedure [dbo].[sp_eduDiaPhuong_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduDiaPhuong_Update]
	@ID_dia_phuong INT,
	@Ma_dia_phuong NVARCHAR(50),
	@Ten_dia_phuong NVARCHAR(50)
AS
	UPDATE eduDiaPhuong SET
	Ma_dia_phuong = @Ma_dia_phuong,
	Ten_dia_phuong = @Ten_dia_phuong
	WHERE ID_dia_phuong = @ID_dia_phuong
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocBongSinhVien_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHocBongSinhVien_Load_List]
AS
	SELECT hb.*,loai.Ten_loai_hoc_bong,sv.Ho_ten
	FROM eduHocBongSinhVien hb
	INNER JOIN eduLoaiHocBong loai
	ON hb.ID_loai = loai.ID_loai_hoc_bong
	INNER JOIN eduSinhVien sv
	ON hb.ID_sinh_vien = sv.ID_sinh_vien



GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocHam_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHocHam_Load_List]
AS
SELECT * FROM eduHocHam
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHocVi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHocVi_Load_List]
AS
SELECT * FROM eduHocVi
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHoiThao_Delete]
@ID_hoi_thao INT
AS
DELETE FROM eduHoiThao WHERE ID_hoi_thao = @ID_hoi_thao
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHoiThao_Insert]
@Ten_hoi_thao NVARCHAR(MAX),
@Ngay_bat_dau DATE,
@Ngay_ket_thuc DATE
AS 
INSERT INTO eduHoiThao(Ten_hoi_thao,Ngay_bat_dau,Ngay_ket_thuc)
	VALUES(@Ten_hoi_thao,@Ngay_bat_dau,@Ngay_ket_thuc)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHoiThao_Load_List]
AS 
SELECT * FROM eduHoiThao
GO
/****** Object:  StoredProcedure [dbo].[sp_eduHoiThao_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduHoiThao_Update]
@ID_hoi_thao INT,
@Ten_hoi_thao NVARCHAR(MAX),
@Ngay_bat_dau DATE,
@Ngay_ket_thuc DATE
AS 
UPDATE eduHoiThao SET Ten_hoi_thao = @Ten_hoi_thao, Ngay_bat_dau = @Ngay_bat_dau, Ngay_ket_thuc = @Ngay_bat_dau
WHERE ID_hoi_thao = @ID_hoi_thao
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiHocBong_Delete]
@ID_loai_hoc_bong INT
AS 
DELETE FROM eduLoaiHocBong WHERE ID_loai_hoc_bong  = @ID_loai_hoc_bong
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiHocBong_Insert]
@Ten_loai_hoc_bong NVARCHAR(50),
@Gia_tri DECIMAL,
@Nam INT
AS
INSERT INTO eduLoaiHocBong(Ten_loai_hoc_bong,Gia_tri,Nam)
	VALUES(@Ten_loai_hoc_bong,@Gia_tri,@Nam)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiHocBong_Load_List]
AS
SELECT * FROM eduLoaiHocBong
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHocBong_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiHocBong_Update]
@ID_loai_hoc_bong INT,
@Ten_loai_hoc_bong NVARCHAR(50),
@Gia_tri DECIMAL,
@Nam INT
AS
UPDATE eduLoaiHocBong SET Ten_loai_hoc_bong = @Ten_loai_hoc_bong,Gia_tri = @Gia_tri, Nam = @Nam
WHERE ID_loai_hoc_bong = @ID_loai_hoc_bong
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiHoTro_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiHoTro_Load_List]
AS
SELECT * FROM eduLoaiHoTro
GO
/****** Object:  StoredProcedure [dbo].[sp_eduLoaiVeMoi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduLoaiVeMoi_Load_List]
AS
SELECT * FROM eduLoaiVeMoi
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhongHop_Delete]
	@ID_phong_hop INT
AS
	DELETE FROM eduPhongHop WHERE ID_phong_hop = @ID_phong_hop
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhongHop_Insert]
@Ma_phong NVARCHAR(50),
@Ten_phong NVARCHAR(50),
@Suc_chua INT,
@So_hang INT,
@So_cot INT,
@ID_hoi_thao INT
AS
INSERT INTO eduPhongHop(Ma_phong,Ten_phong,Suc_chua,So_hang,So_cot,ID_hoi_thao)
	VALUES(@Ma_phong,@Ten_phong,@Suc_chua,@So_hang,@So_cot,@ID_hoi_thao)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhongHop_Load_List]
AS
SELECT eduPhongHop.*,eduHoiThao.Ten_hoi_thao
FROM eduPhongHop
INNER JOIN eduHoiThao ON eduPhongHop.ID_hoi_thao = eduHoiThao.ID_hoi_thao
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhongHop_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhongHop_Update]
	@ID_phong_hop INT,
	@Ma_phong NVARCHAR(50),
	@Ten_phong NVARCHAR(50),
	@Suc_chua INT,
	@So_hang INT,
	@So_cot INT,
	@ID_hoi_thao INT
AS
UPDATE eduPhongHop SET
	Ma_phong = @Ma_phong,
	Ten_phong = @Ten_phong,
	Suc_chua = @Suc_chua,
	So_hang = @So_hang,
	So_cot = @So_cot,
	ID_hoi_thao = @ID_hoi_thao
WHERE ID_phong_hop = @ID_phong_hop

IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhuongPhapNghienCuu_Delete]
@ID_phuong_phap INT
AS
	DELETE FROM eduPhuongPhapNghienCuu WHERE ID_phuong_phap = @ID_phuong_phap
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhuongPhapNghienCuu_Insert]
	@Ten_phuong_phap NVARCHAR(50),
	@Ngay_tao DATE,
	@Trang_thai INT
AS
	INSERT INTO eduPhuongPhapNghienCuu(Ten_phuong_phap,Ngay_tao,Trang_thai)
		VALUES(@Ten_phuong_phap,@Ngay_tao,@Trang_thai)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhuongPhapNghienCuu_Load_List]
AS
SELECT * FROM eduPhuongPhapNghienCuu
GO
/****** Object:  StoredProcedure [dbo].[sp_eduPhuongPhapNghienCuu_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduPhuongPhapNghienCuu_Update]
	@ID_phuong_phap INT,
	@Ten_phuong_phap NVARCHAR(50),
	@Ngay_tao DATE,
	@Trang_thai INT
AS
	UPDATE eduPhuongPhapNghienCuu SET
	Ten_phuong_phap = @Ten_phuong_phap,
	Ngay_tao = @Ngay_tao, 
	Trang_thai = @Trang_thai
WHERE
	ID_phuong_phap = @ID_phuong_phap
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduSinhVien_Delete]
@ID_sinh_vien INT
AS
DELETE FROM eduSinhVien WHERE ID_sinh_vien = @ID_sinh_vien
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduSinhVien_Insert]
@Ho_ten NVARCHAR(50),
@Dia_chi NVARCHAR(50),
@Email NVARCHAR(50),
@So_dien_thoai NVARCHAR(50),
@CCCD NVARCHAR(20),
@Gioi_tinh BIT,
@Ngay_sinh DATE,
@ID_truong INT
AS
INSERT eduSinhVien(Ho_ten,Dia_chi,Email,So_dien_thoai,CCCD,Gioi_tinh,Ngay_sinh,ID_truong)
	VALUES(@Ho_ten,@Dia_chi,@Email,@So_dien_thoai,@CCCD,@Gioi_tinh,@Ngay_sinh,@ID_truong)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduSinhVien_Load_List]
AS
SELECT eduSinhVien.*,eduTruongHoc.Ten_truong 
FROM eduSinhVien
INNER JOIN eduTruongHoc 
ON eduSinhVien.ID_truong = eduTruongHoc.ID_truong
GO
/****** Object:  StoredProcedure [dbo].[sp_eduSinhVien_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduSinhVien_Update]
@ID_sinh_vien INT,
@Ho_ten NVARCHAR(50),
@Dia_chi NVARCHAR(50),
@Email NVARCHAR(50),
@So_dien_thoai NVARCHAR(50),
@CCCD NVARCHAR(20),
@Gioi_tinh BIT,
@Ngay_sinh DATE,
@ID_truong INT
AS
UPDATE eduSinhVien SET
	Ho_ten = @Ho_ten,
	Dia_chi = @Dia_chi,
	Email = @Email,
	So_dien_thoai = @So_dien_thoai,
	CCCD = @CCCD,
	Gioi_tinh = @Gioi_tinh,
	Ngay_sinh = @Ngay_sinh,
	ID_truong = @ID_truong
WHERE ID_sinh_vien = @ID_sinh_vien
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTaiLieuHoiThao_Delete]
	@ID_tai_lieu INT
AS
DELETE FROM eduTaiLieuHoiThao WHERE ID_tai_lieu = @ID_tai_lieu
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTaiLieuHoiThao_Insert]
	@Ten_tai_lieu NVARCHAR(50),
	@Mo_ta NVARCHAR(MAX),
	@ID_hoi_thao INT,
	@FileName NVARCHAR(MAX),
	@Url NVARCHAR(MAX),
	@DocType NVARCHAR(MAX),
	@FileDoc NVARCHAR(MAX)
AS
INSERT INTO eduTaiLieuHoiThao(Ten_tai_lieu,Mo_ta,ID_hoi_thao,FileName,Url,DocType,FileDoc)
	VALUES(@Ten_tai_lieu,@Mo_ta,@ID_hoi_thao,@FileName,@Url,@DocType,@FileDoc)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTaiLieuHoiThao_Load_List]
AS
SELECT eduTaiLieuHoiThao.*,eduHoiThao.Ten_hoi_thao
FROM eduTaiLieuHoiThao
INNER JOIN eduHoiThao
ON eduTaiLieuHoiThao.ID_hoi_thao = eduHoiThao.ID_hoi_thao
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTaiLieuHoiThao_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTaiLieuHoiThao_Update]
	@ID_tai_lieu INT,
	@Ten_tai_lieu NVARCHAR(50),
	@Mo_ta NVARCHAR(MAX),
	@ID_hoi_thao INT,
	@FileName NVARCHAR(MAX),
	@Url NVARCHAR(MAX),
	@DocType NVARCHAR(MAX),
	@FileDoc NVARCHAR(MAX)
AS
UPDATE eduTaiLieuHoiThao SET Ten_tai_lieu = @Ten_tai_lieu,Mo_ta = @Mo_ta,ID_hoi_thao = @ID_hoi_thao,FileName = @FileName,Url = @Url,DocType = @DocType,FileDoc = @FileDoc
WHERE ID_tai_lieu = @ID_tai_lieu
IF @@ROWCOUNT = 0 
	SELECT 0 AS Updated
ELSE 
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTrungTam_Delete]
@ID_trung_tam INT
AS
DELETE FROM eduTrungTam WHERE ID_trung_tam = @ID_trung_tam
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTrungTam_Insert]
@Ma_trung_tam NVARCHAR(50),
@Ten_trung_tam NVARCHAR(50),
@Dia_chi NVARCHAR(50),
@So_dien_thoai NVARCHAR(50)
AS
INSERT INTO eduTrungTam(Ma_trung_tam,Ten_trung_tam,Dia_chi,So_dien_thoai)
	VALUES(@Ma_trung_tam,@Ten_trung_tam,@Dia_chi,@So_dien_thoai)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTrungTam_Load_List] 
AS 
SELECT * FROM eduTrungTam
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTrungTam_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTrungTam_Update]
@ID_trung_tam INT,
@Ma_trung_tam NVARCHAR(50),
@Ten_trung_tam NVARCHAR(50),
@Dia_chi NVARCHAR(50),
@So_dien_thoai NVARCHAR(50)
AS
UPDATE eduTrungTam SET Ma_trung_tam = @Ma_trung_tam,Ten_trung_tam = @Ten_trung_tam,Dia_chi = @Dia_chi,So_dien_thoai = @So_dien_thoai
WHERE ID_trung_tam = @ID_trung_tam
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete]
@ID_th_ct INT
AS
DELETE FROM eduTruongHoc_CongTrinhNC WHERE ID_th_ct = @ID_th_ct
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong]	
@ID_truong INT
AS
DELETE FROM eduTruongHoc_CongTrinhNC WHERE ID_truong = @ID_truong
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_CongTrinhNC_Insert]
@ID_cong_trinh INT,
@ID_truong INT
AS
INSERT INTO eduTruongHoc_CongTrinhNC(ID_cong_trinh,ID_truong)
	VALUES(@ID_cong_trinh,@ID_truong)
SELECT @@IDENTITY As 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_CongTrinhNC_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_CongTrinhNC_Load_List] 
@ID_truong INT
AS
SELECT th_ct.*,ct.Ten_cong_trinh,ct.Ngay_tao,ct.Trang_thai,cg.Ten_chuyen_gia
FROM eduTruongHoc_CongTrinhNC th_ct
LEFT JOIN eduCongTrinhNghienCuu ct
ON th_ct.ID_cong_trinh = ct.ID_cong_trinh
LEFT JOIN eduChuyenGia cg
ON th_ct.ID_cong_trinh = cg.ID_cong_trinh
WHERE th_ct.ID_truong = @ID_truong

GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_Delete]
@ID_truong INT
AS
DELETE FROM eduTruongHoc WHERE ID_truong = @ID_truong
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_Insert]
@Ma_truong NVARCHAR(50),
@Ten_truong NVARCHAR(50),
@Dia_chi NVARCHAR(50)
AS
INSERT INTO eduTruongHoc(Ma_truong,Ten_truong,Dia_chi)
VALUES(@Ma_truong,@Ten_truong,@Dia_chi)
SELECT @@IDENTITY AS 'Identity';  
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_Load_List]
AS
SELECT * FROM eduTruongHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_PhuongPhapNC_Delete]
@ID_th_pp INT
AS
DELETE FROM eduTruongHoc_PhuongPhapNC WHERE ID_th_pp = @ID_th_pp
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_PhuongPhapNC_Insert]
@ID_phuong_phap INT,
@ID_truong INT
AS
INSERT INTO eduTruongHoc_PhuongPhapNC(ID_phuong_phap,ID_truong)
	VALUES(@ID_phuong_phap,@ID_truong)
SELECT @@IDENTITY As 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_PhuongPhapNC_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_PhuongPhapNC_Load_List] 
@ID_truong INT
AS
SELECT th_pp.*,pp.Ten_phuong_phap,pp.Ngay_tao,pp.Trang_thai,cg.Ten_chuyen_gia
FROM eduTruongHoc_PhuongPhapNC th_pp
LEFT JOIN eduPhuongPhapNghienCuu pp
ON th_pp.ID_phuong_phap = pp.ID_phuong_phap
LEFT JOIN eduChuyenGia cg
ON th_pp.ID_phuong_phap = pp.ID_phuong_phap
WHERE th_pp.ID_truong = @ID_truong

GO
/****** Object:  StoredProcedure [dbo].[sp_eduTruongHoc_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTruongHoc_Update]
@ID_truong INT,
@Ma_truong NVARCHAR(50),
@Ten_truong NVARCHAR(50),
@Dia_chi NVARCHAR(50)
AS
UPDATE eduTruongHoc SET Ma_truong = @Ma_truong,Ten_truong = @Ten_truong,Dia_chi = @Dia_chi 
WHERE ID_truong = @ID_truong
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
Else
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong]
@ID_truong INT
AS
DELETE FROM eduTruongHoc_PhuongPhapNC WHERE ID_truong = @ID_truong
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduVeMoi_Delete]
	@ID_ve_moi INT
AS
	DELETE FROM eduVeMoi WHERE ID_ve_moi = @ID_ve_moi
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Insert]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduVeMoi_Insert]
	@Ten_ve NVARCHAR(50),
	@Ngay_bat_dau DATE,
	@Ngay_ket_thuc DATE,
	@ID_loai INT
AS
	INSERT INTO eduVeMoi(Ten_ve,Ngay_bat_dau,Ngay_ket_thuc,ID_loai)
		VALUES(@Ten_ve,@Ngay_bat_dau,@Ngay_ket_thuc,@ID_loai)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Load_List]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduVeMoi_Load_List]
AS
	SELECT ve.*,loai.Ten_loai
	FROM eduVeMoi ve
	INNER JOIN eduLoaiVeMoi loai
	ON ve.ID_loai = loai.ID_loai
GO
/****** Object:  StoredProcedure [dbo].[sp_eduVeMoi_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_eduVeMoi_Update]
	@ID_ve_moi INT,
	@Ten_ve NVARCHAR(50),
	@Ngay_bat_dau DATE,
	@Ngay_ket_thuc DATE,
	@ID_loai INT
AS
	UPDATE eduVeMoi SET 
	Ten_ve = @Ten_ve,
	Ngay_bat_dau = @Ngay_bat_dau,
	Ngay_ket_thuc = @Ngay_ket_thuc,
	ID_loai = @ID_loai
	WHERE ID_ve_moi = @ID_ve_moi
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_ChangePassword]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO





---------------------------------------------------------------------------
-- Author : Đỗ Văn Lộc
-- Company : Thiên An Technology
-- Alterd Date : 04/11/2008
---------------------------------------------------------------------------
--Test: sp_htUsers_ChangePassword 'admin','ICy5YqxZB1uWSwcVLSNLcA==','ICy5YqxZB1uWSwcVLSNLcA=='
CREATE PROCEDURE [dbo].[sp_htUsers_ChangePassword]
	@UserName	nvarchar(20),
	@PassWordOld	nvarchar(50),
	@PasswordNew  nvarchar(50)
AS
UPDATE	htUsers
SET PassWord=@PasswordNew
WHERE (UPPER(UserName) = UPPER(@UserName)) AND (PassWord=@PassWordOld)

select @@ROWCOUNT  as ROW


GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Login]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO





---------------------------------------------------------------------------
-- Author : Đỗ Văn Lộc
-- Company : Thiên An Technology
-- Alterd Date : 04/11/2008
---------------------------------------------------------------------------
--Test: sp_htUsers_Login 'admin','ICy5YqxZB1uWSwcVLSNLcA=='
CREATE PROCEDURE [dbo].[sp_htUsers_Login]
	@UserName	nvarchar(20),
	@PassWord	nvarchar(50)
AS
SELECT	*
FROM	htUsers
WHERE (UPPER(UserName) = UPPER(@UserName)) AND (PassWord=@PassWord) and Active=1



GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Update]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
---------------------------------------------------------------------------
-- Author : Đỗ Văn Lộc
-- Company : Thiên An Technology
-- Created Date : Monday, February 25, 2019
---------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_htUsers_Update]
	@UserID  int,
	@FullName  nvarchar(50),
	@Admin  bit,
	@Active  bit,
	@Email nvarchar(100)
AS
UPDATE htUsers SET
	FullName = @FullName,
	Admin = @Admin,
	Active = @Active,
	Email=@Email
WHERE (UserID = @UserID)

IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
Else
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_UpdateInfo]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_htUsers_UpdateInfo]
@UserID INT,
@FullName NVARCHAR(50),
@Email NVARCHAR(50)
AS 
UPDATE htUsers SET FullName = @FullName,Email = @Email WHERE UserID = @UserID
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
Else
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_UpdatePassword]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO






---------------------------------------------------------------------------
-- Author : Đỗ Văn Lộc
-- Company : Thiên An Technology
-- Alterd Date : 04/11/2008
---------------------------------------------------------------------------
--Test: sp_htUsers_ChangePassword 'admin','ICy5YqxZB1uWSwcVLSNLcA=='
CREATE PROCEDURE [dbo].[sp_htUsers_UpdatePassword]
	@UserName	nvarchar(20),
	@PasswordNew  nvarchar(50)
AS
UPDATE	htUsers
SET PassWord=@PasswordNew
WHERE (UPPER(UserName) = UPPER(@UserName))
GO
/****** Object:  StoredProcedure [dbo].[sp_Urcheck]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Urcheck]
	@UserName  nvarchar(50),
	@Password  nvarchar(50)
AS
SELECT * FROM htUsers
WHERE UserName = @UserName AND PassWord = @Password
GO
/****** Object:  StoredProcedure [dbo].[sp_Urcheck_delete]    Script Date: 8/25/2021 7:18:07 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
---------------------------------------------------------------------------
-- Author : Phan Nhật Anh
-- Company : Thiên An Technology
-- Created Date :16/7/2019
---------------------------------------------------------------------------
create PROCEDURE [dbo].[sp_Urcheck_delete]
	@UserID  int
AS
SELECT * FROM htUpdateVersion
WHERE (UserID = @UserID)

GO
