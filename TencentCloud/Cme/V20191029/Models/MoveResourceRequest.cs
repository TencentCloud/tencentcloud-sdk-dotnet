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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MoveResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 待移动的原始资源信息，包含原始媒体或分类资源，以及资源归属。
        /// </summary>
        [JsonProperty("SourceResource")]
        public ResourceInfo SourceResource{ get; set; }

        /// <summary>
        /// 目标信息，包含分类及归属，仅支持移动资源到分类。
        /// </summary>
        [JsonProperty("DestinationResource")]
        public ResourceInfo DestinationResource{ get; set; }

        /// <summary>
        /// 操作者。填写用户的 Id，用于标识调用者及校验资源访问以及写权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamObj(map, prefix + "SourceResource.", this.SourceResource);
            this.SetParamObj(map, prefix + "DestinationResource.", this.DestinationResource);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

