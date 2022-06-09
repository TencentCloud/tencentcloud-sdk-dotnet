/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeIndonesiaIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("NIK")]
        public string NIK{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Nama")]
        public string Nama{ get; set; }

        /// <summary>
        /// 出生地/出生时间
        /// </summary>
        [JsonProperty("TempatTglLahir")]
        public string TempatTglLahir{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("JenisKelamin")]
        public string JenisKelamin{ get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        [JsonProperty("GolDarah")]
        public string GolDarah{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Alamat")]
        public string Alamat{ get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonProperty("RTRW")]
        public string RTRW{ get; set; }

        /// <summary>
        /// 村
        /// </summary>
        [JsonProperty("KelDesa")]
        public string KelDesa{ get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("Kecamatan")]
        public string Kecamatan{ get; set; }

        /// <summary>
        /// 宗教信仰
        /// </summary>
        [JsonProperty("Agama")]
        public string Agama{ get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [JsonProperty("StatusPerkawinan")]
        public string StatusPerkawinan{ get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [JsonProperty("Perkerjaan")]
        public string Perkerjaan{ get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonProperty("KewargaNegaraan")]
        public string KewargaNegaraan{ get; set; }

        /// <summary>
        /// 身份证有效期限
        /// </summary>
        [JsonProperty("BerlakuHingga")]
        public string BerlakuHingga{ get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// 人像截图
        /// </summary>
        [JsonProperty("Photo")]
        public string Photo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NIK", this.NIK);
            this.SetParamSimple(map, prefix + "Nama", this.Nama);
            this.SetParamSimple(map, prefix + "TempatTglLahir", this.TempatTglLahir);
            this.SetParamSimple(map, prefix + "JenisKelamin", this.JenisKelamin);
            this.SetParamSimple(map, prefix + "GolDarah", this.GolDarah);
            this.SetParamSimple(map, prefix + "Alamat", this.Alamat);
            this.SetParamSimple(map, prefix + "RTRW", this.RTRW);
            this.SetParamSimple(map, prefix + "KelDesa", this.KelDesa);
            this.SetParamSimple(map, prefix + "Kecamatan", this.Kecamatan);
            this.SetParamSimple(map, prefix + "Agama", this.Agama);
            this.SetParamSimple(map, prefix + "StatusPerkawinan", this.StatusPerkawinan);
            this.SetParamSimple(map, prefix + "Perkerjaan", this.Perkerjaan);
            this.SetParamSimple(map, prefix + "KewargaNegaraan", this.KewargaNegaraan);
            this.SetParamSimple(map, prefix + "BerlakuHingga", this.BerlakuHingga);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
            this.SetParamSimple(map, prefix + "Photo", this.Photo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

