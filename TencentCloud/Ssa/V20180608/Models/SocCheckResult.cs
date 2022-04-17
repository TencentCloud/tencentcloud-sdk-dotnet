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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SocCheckResult : AbstractModel
    {
        
        /// <summary>
        /// 检查项的uuid
        /// </summary>
        [JsonProperty("CheckId")]
        public string CheckId{ get; set; }

        /// <summary>
        /// 配置要求
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 检查项的类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 检查对象
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("PloyName")]
        public string PloyName{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PloyId")]
        public long? PloyId{ get; set; }

        /// <summary>
        /// 正常,低危,中危,高危
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 不符合数
        /// </summary>
        [JsonProperty("FailAssetNum")]
        public long? FailAssetNum{ get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalAssetNum")]
        public long? TotalAssetNum{ get; set; }

        /// <summary>
        /// 处置建议url链接
        /// </summary>
        [JsonProperty("DealUrl")]
        public string DealUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckId", this.CheckId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PloyName", this.PloyName);
            this.SetParamSimple(map, prefix + "PloyId", this.PloyId);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "FailAssetNum", this.FailAssetNum);
            this.SetParamSimple(map, prefix + "TotalAssetNum", this.TotalAssetNum);
            this.SetParamSimple(map, prefix + "DealUrl", this.DealUrl);
        }
    }
}

