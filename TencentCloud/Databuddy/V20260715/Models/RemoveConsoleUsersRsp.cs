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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemoveConsoleUsersRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>请求已完成处理；即使部分失败也为 true，逐个结果以 SuccessUins/FailItems 为准</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>删除成功的用户 UIN 列表</p>
        /// </summary>
        [JsonProperty("SuccessUins")]
        public string[] SuccessUins{ get; set; }

        /// <summary>
        /// <p>失败项列表（Item 为用户 UIN，FailReason 为失败原因）</p>
        /// </summary>
        [JsonProperty("FailItems")]
        public CommonFailItem[] FailItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SuccessUins.", this.SuccessUins);
            this.SetParamArrayObj(map, prefix + "FailItems.", this.FailItems);
        }
    }
}

