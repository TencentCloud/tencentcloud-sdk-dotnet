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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCheckParams : AbstractModel
    {
        
        /// <summary>
        /// 健康检查的时间间隔
        /// </summary>
        [JsonProperty("DelayLoop")]
        public ulong? DelayLoop{ get; set; }

        /// <summary>
        /// 健康检查的响应超时时间
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// 健康检查的检查路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 健康检查的方法，GET/HEAD
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 确认源站正常的返回码，可选范围[100, 200, 300, 400, 500]
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong?[] StatusCode{ get; set; }

        /// <summary>
        /// 健康检查的检查域名。
        /// 当调用ModifyRuleAttribute时，不支持修改该参数。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DelayLoop", this.DelayLoop);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "StatusCode.", this.StatusCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

