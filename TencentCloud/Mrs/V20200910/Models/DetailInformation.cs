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

    public class DetailInformation : AbstractModel
    {
        
        /// <summary>
        /// 部位
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 组织大小
        /// </summary>
        [JsonProperty("TissueSizes")]
        public Size[] TissueSizes{ get; set; }

        /// <summary>
        /// 结节大小
        /// </summary>
        [JsonProperty("TuberSizes")]
        public Size[] TuberSizes{ get; set; }

        /// <summary>
        /// 肿瘤大小
        /// </summary>
        [JsonProperty("CancerSizes")]
        public Size[] CancerSizes{ get; set; }

        /// <summary>
        /// 组织学等级
        /// </summary>
        [JsonProperty("HistologyLevel")]
        public BaseInfo HistologyLevel{ get; set; }

        /// <summary>
        /// 组织学类型
        /// </summary>
        [JsonProperty("HistologyType")]
        public HistologyTypeV2 HistologyType{ get; set; }

        /// <summary>
        /// 侵犯
        /// </summary>
        [JsonProperty("Invasive")]
        public InvasiveV2[] Invasive{ get; set; }

        /// <summary>
        /// pTNM
        /// </summary>
        [JsonProperty("PTNM")]
        public PTNM PTNM{ get; set; }

        /// <summary>
        /// 浸润深度
        /// </summary>
        [JsonProperty("InfiltrationDepth")]
        public BaseInfo InfiltrationDepth{ get; set; }

        /// <summary>
        /// 结节数量
        /// </summary>
        [JsonProperty("TuberNum")]
        public BaseInfo TuberNum{ get; set; }

        /// <summary>
        /// 钙化
        /// </summary>
        [JsonProperty("Calcification")]
        public BaseInfo Calcification{ get; set; }

        /// <summary>
        /// 坏死
        /// </summary>
        [JsonProperty("Necrosis")]
        public BaseInfo Necrosis{ get; set; }

        /// <summary>
        /// 异形
        /// </summary>
        [JsonProperty("Abnormity")]
        public BaseInfo Abnormity{ get; set; }

        /// <summary>
        /// 断链
        /// </summary>
        [JsonProperty("Breaked")]
        public BaseInfo Breaked{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamArrayObj(map, prefix + "TissueSizes.", this.TissueSizes);
            this.SetParamArrayObj(map, prefix + "TuberSizes.", this.TuberSizes);
            this.SetParamArrayObj(map, prefix + "CancerSizes.", this.CancerSizes);
            this.SetParamObj(map, prefix + "HistologyLevel.", this.HistologyLevel);
            this.SetParamObj(map, prefix + "HistologyType.", this.HistologyType);
            this.SetParamArrayObj(map, prefix + "Invasive.", this.Invasive);
            this.SetParamObj(map, prefix + "PTNM.", this.PTNM);
            this.SetParamObj(map, prefix + "InfiltrationDepth.", this.InfiltrationDepth);
            this.SetParamObj(map, prefix + "TuberNum.", this.TuberNum);
            this.SetParamObj(map, prefix + "Calcification.", this.Calcification);
            this.SetParamObj(map, prefix + "Necrosis.", this.Necrosis);
            this.SetParamObj(map, prefix + "Abnormity.", this.Abnormity);
            this.SetParamObj(map, prefix + "Breaked.", this.Breaked);
        }
    }
}

