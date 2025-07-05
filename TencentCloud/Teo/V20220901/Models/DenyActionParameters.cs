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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DenyActionParameters : AbstractModel
    {
        
        /// <summary>
        /// 是否对来源 IP 延长封禁。取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 启用后，对触发规则的客户端 IP 持续拦截。当启用该选项时，必须同时指定 BlockIpDuration 参数。
        /// 注意：该选项不可与 ReturnCustomPage 或 Stall 选项同时启用。
        /// </summary>
        [JsonProperty("BlockIp")]
        public string BlockIp{ get; set; }

        /// <summary>
        /// 当 BlockIP 为 on 时IP 的封禁时长。
        /// </summary>
        [JsonProperty("BlockIpDuration")]
        public string BlockIpDuration{ get; set; }

        /// <summary>
        /// 是否使用自定义页面。取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 启用后，使用自定义页面内容拦截（响应）请求，当启用该选项时，必须同时指定 ResponseCode 和 ErrorPageId 参数。
        /// 注意：该选项不可与 BlockIp 或 Stall 选项同时启用。
        /// </summary>
        [JsonProperty("ReturnCustomPage")]
        public string ReturnCustomPage{ get; set; }

        /// <summary>
        /// 自定义页面的状态码。
        /// </summary>
        [JsonProperty("ResponseCode")]
        public string ResponseCode{ get; set; }

        /// <summary>
        /// 自定义页面的PageId。
        /// </summary>
        [JsonProperty("ErrorPageId")]
        public string ErrorPageId{ get; set; }

        /// <summary>
        /// 是否对请求来源挂起不予处理。取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 启用后，不再响应当前连接会话内请求，且不会主动断开连接。用于爬虫对抗时，消耗客户端连接资源。
        /// 注意：该选项不可与 BlockIp 或 ReturnCustomPage 选项同时启用。
        /// </summary>
        [JsonProperty("Stall")]
        public string Stall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockIp", this.BlockIp);
            this.SetParamSimple(map, prefix + "BlockIpDuration", this.BlockIpDuration);
            this.SetParamSimple(map, prefix + "ReturnCustomPage", this.ReturnCustomPage);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
            this.SetParamSimple(map, prefix + "ErrorPageId", this.ErrorPageId);
            this.SetParamSimple(map, prefix + "Stall", this.Stall);
        }
    }
}

