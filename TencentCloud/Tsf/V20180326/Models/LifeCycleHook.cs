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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifeCycleHook : AbstractModel
    {
        
        /// <summary>
        /// 生命周期函数类型：PostStart|PreStop
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HookType")]
        public string HookType{ get; set; }

        /// <summary>
        /// 函数执行方式：execCommand|httpGet|none
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecMode")]
        public string ExecMode{ get; set; }

        /// <summary>
        /// execCommand函数执行内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecCommandContent")]
        public string ExecCommandContent{ get; set; }

        /// <summary>
        /// HttpGet执行内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpGetOption")]
        public HttpGetOption HttpGetOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HookType", this.HookType);
            this.SetParamSimple(map, prefix + "ExecMode", this.ExecMode);
            this.SetParamSimple(map, prefix + "ExecCommandContent", this.ExecCommandContent);
            this.SetParamObj(map, prefix + "HttpGetOption.", this.HttpGetOption);
        }
    }
}

