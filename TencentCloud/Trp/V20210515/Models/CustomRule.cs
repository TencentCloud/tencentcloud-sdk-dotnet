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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomRule : AbstractModel
    {
        
        /// <summary>
        /// 码规则ID
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 码规则名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 码ID长度
        /// </summary>
        [JsonProperty("CodeLength")]
        public ulong? CodeLength{ get; set; }

        /// <summary>
        /// 规则状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 码段配置
        /// </summary>
        [JsonProperty("CodeParts")]
        public CodePart[] CodeParts{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "CodeLength", this.CodeLength);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "CodeParts.", this.CodeParts);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

