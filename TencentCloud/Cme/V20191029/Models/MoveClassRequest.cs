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

    public class MoveClassRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 归属者。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 源分类路径。
        /// </summary>
        [JsonProperty("SourceClassPath")]
        public string SourceClassPath{ get; set; }

        /// <summary>
        /// 目标分类路径。
        /// </summary>
        [JsonProperty("DestinationClassPath")]
        public string DestinationClassPath{ get; set; }

        /// <summary>
        /// 操作者。填写用户的 Id，用于标识调用者及校验操作权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "SourceClassPath", this.SourceClassPath);
            this.SetParamSimple(map, prefix + "DestinationClassPath", this.DestinationClassPath);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

