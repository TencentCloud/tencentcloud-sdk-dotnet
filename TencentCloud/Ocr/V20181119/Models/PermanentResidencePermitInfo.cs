/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class PermanentResidencePermitInfo : AbstractModel
    {
        
        /// <summary>
        /// 姓名（人像面）
        /// </summary>
        [JsonProperty("Name")]
        public ContentInfo Name{ get; set; }

        /// <summary>
        /// 性别（人像面）
        /// </summary>
        [JsonProperty("Sex")]
        public ContentInfo Sex{ get; set; }

        /// <summary>
        /// 民族（人像面）
        /// </summary>
        [JsonProperty("Nation")]
        public ContentInfo Nation{ get; set; }

        /// <summary>
        /// 出生日期（人像面）
        /// </summary>
        [JsonProperty("Birth")]
        public ContentInfo Birth{ get; set; }

        /// <summary>
        /// 地址（人像面）
        /// </summary>
        [JsonProperty("Address")]
        public ContentInfo Address{ get; set; }

        /// <summary>
        /// 公民身份号码（人像面）
        /// </summary>
        [JsonProperty("IdNum")]
        public ContentInfo IdNum{ get; set; }

        /// <summary>
        /// 发证机关（国徽面）
        /// </summary>
        [JsonProperty("Authority")]
        public ContentInfo Authority{ get; set; }

        /// <summary>
        /// 证件有效期（国徽面）
        /// </summary>
        [JsonProperty("ValidDate")]
        public ContentInfo ValidDate{ get; set; }

        /// <summary>
        /// WarnInfos，告警信息
        /// </summary>
        [JsonProperty("WarnInfos")]
        public CardWarnInfo WarnInfos{ get; set; }

        /// <summary>
        /// IdCard，裁剪后身份证照片的base64编码，请求 EnableCropImage 时返回；
        /// </summary>
        [JsonProperty("CardImage")]
        public ContentInfo CardImage{ get; set; }

        /// <summary>
        /// Portrait，身份证头像照片的base64编码，请求 EnablePortrait 时返回；
        /// </summary>
        [JsonProperty("PortraitImage")]
        public ContentInfo PortraitImage{ get; set; }

        /// <summary>
        /// 持证人持有号码，外国人永久居留证 返回该字段
        /// </summary>
        [JsonProperty("HolderNum")]
        public ContentInfo HolderNum{ get; set; }

        /// <summary>
        /// 国籍，外国人永久居留证 返回该字段
        /// </summary>
        [JsonProperty("Nationality")]
        public ContentInfo Nationality{ get; set; }

        /// <summary>
        /// 英文名
        /// 示例值：Ming Li
        /// </summary>
        [JsonProperty("EnName")]
        public ContentInfo EnName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "Sex.", this.Sex);
            this.SetParamObj(map, prefix + "Nation.", this.Nation);
            this.SetParamObj(map, prefix + "Birth.", this.Birth);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "IdNum.", this.IdNum);
            this.SetParamObj(map, prefix + "Authority.", this.Authority);
            this.SetParamObj(map, prefix + "ValidDate.", this.ValidDate);
            this.SetParamObj(map, prefix + "WarnInfos.", this.WarnInfos);
            this.SetParamObj(map, prefix + "CardImage.", this.CardImage);
            this.SetParamObj(map, prefix + "PortraitImage.", this.PortraitImage);
            this.SetParamObj(map, prefix + "HolderNum.", this.HolderNum);
            this.SetParamObj(map, prefix + "Nationality.", this.Nationality);
            this.SetParamObj(map, prefix + "EnName.", this.EnName);
        }
    }
}

