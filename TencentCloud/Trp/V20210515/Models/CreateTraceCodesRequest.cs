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

    public class CreateTraceCodesRequest : AbstractModel
    {
        
        /// <summary>
        /// 批次ID
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 码
        /// </summary>
        [JsonProperty("Codes")]
        public CodeItem[] Codes{ get; set; }

        /// <summary>
        /// 码绑定激活策略，默认  0
        /// 0: 传什么码就激活什么码
        /// 1: 层级码 + 层级子码
        /// </summary>
        [JsonProperty("CodeType")]
        public ulong? CodeType{ get; set; }

        /// <summary>
        /// 错误检查类型，默认 0
        /// 0: 没有新导入码时正常返回
        /// 1: 没有新导入码时报错，并返回没有导入成功的原因
        /// </summary>
        [JsonProperty("CheckType")]
        public ulong? CheckType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamArrayObj(map, prefix + "Codes.", this.Codes);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
        }
    }
}

