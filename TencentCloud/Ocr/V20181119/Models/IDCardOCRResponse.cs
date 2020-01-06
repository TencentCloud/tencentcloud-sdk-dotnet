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

    public class IDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 姓名（人像面）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 性别（人像面）
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 民族（人像面）
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// 出生日期（人像面）
        /// </summary>
        [JsonProperty("Birth")]
        public string Birth{ get; set; }

        /// <summary>
        /// 地址（人像面）
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 身份证号（人像面）
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// 发证机关（国徽面）
        /// </summary>
        [JsonProperty("Authority")]
        public string Authority{ get; set; }

        /// <summary>
        /// 证件有效期（国徽面）
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// 扩展信息，根据请求的可选字段返回对应内容，不请求则不返回，具体输入参考示例3和示例4。
        /// 
        /// 目前支持的扩展字段为：
        /// IdCard，身份证照片，请求 CropIdCard 时返回；
        /// Portrait，人像照片，请求 CropPortrait 时返回；
        /// WarnInfos，告警信息（Code - 告警码），识别出以下告警内容时返回。
        /// 
        /// Code 告警码列表和释义：
        /// -9100	身份证有效日期不合法告警，
        /// -9101	身份证边框不完整告警，
        /// -9102	身份证复印件告警，
        /// -9103	身份证翻拍告警，
        /// -9105	身份证框内遮挡告警，
        /// -9104	临时身份证告警，
        /// -9106	身份证 PS 告警。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "Birth", this.Birth);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Authority", this.Authority);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

