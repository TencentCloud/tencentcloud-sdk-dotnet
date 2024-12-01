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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SurgeryBaseItem : AbstractModel
    {
        
        /// <summary>
        /// 体检报告-外科-头颈部
        /// </summary>
        [JsonProperty("HeadNeck")]
        public SurgeryHeadNeck HeadNeck{ get; set; }

        /// <summary>
        /// 体检报告-外科-甲状腺
        /// </summary>
        [JsonProperty("Thyroid")]
        public SurgeryThyroid Thyroid{ get; set; }

        /// <summary>
        /// 体检报告-外科-乳房
        /// </summary>
        [JsonProperty("Breast")]
        public SurgeryBreast Breast{ get; set; }

        /// <summary>
        /// 体检报告-外科-浅表淋巴结
        /// </summary>
        [JsonProperty("LymphNode")]
        public SurgeryLymphNode LymphNode{ get; set; }

        /// <summary>
        /// 体检报告-外科-脊柱
        /// </summary>
        [JsonProperty("SpinalExtremities")]
        public SurgerySpinalExtremities SpinalExtremities{ get; set; }

        /// <summary>
        /// 体检报告-外科-皮肤
        /// </summary>
        [JsonProperty("Skin")]
        public SurgerySkin Skin{ get; set; }

        /// <summary>
        /// 体检报告-外科-肛门直肠
        /// </summary>
        [JsonProperty("Anorectal")]
        public SurgeryAnorectal Anorectal{ get; set; }

        /// <summary>
        /// 体检报告-外科-泌尿生殖系统
        /// </summary>
        [JsonProperty("UrogenitalSystem")]
        public SurgeryUrogenitalSystem UrogenitalSystem{ get; set; }

        /// <summary>
        /// 体检报告-外科-外科其他
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 体检报告-外科-小结
        /// </summary>
        [JsonProperty("BriefSummary")]
        public SurgeryBriefSummary BriefSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HeadNeck.", this.HeadNeck);
            this.SetParamObj(map, prefix + "Thyroid.", this.Thyroid);
            this.SetParamObj(map, prefix + "Breast.", this.Breast);
            this.SetParamObj(map, prefix + "LymphNode.", this.LymphNode);
            this.SetParamObj(map, prefix + "SpinalExtremities.", this.SpinalExtremities);
            this.SetParamObj(map, prefix + "Skin.", this.Skin);
            this.SetParamObj(map, prefix + "Anorectal.", this.Anorectal);
            this.SetParamObj(map, prefix + "UrogenitalSystem.", this.UrogenitalSystem);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "BriefSummary.", this.BriefSummary);
        }
    }
}

