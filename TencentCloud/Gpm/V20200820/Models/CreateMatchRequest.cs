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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 匹配名称，[a-zA-Z0-9-\.]* 长度128
        /// </summary>
        [JsonProperty("MatchName")]
        public string MatchName{ get; set; }

        /// <summary>
        /// 规则code
        /// </summary>
        [JsonProperty("RuleCode")]
        public string RuleCode{ get; set; }

        /// <summary>
        /// 超时时间，1-600秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 是否为匹配结果请求服务器资源，0表示否，1表示请求GSE资源
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// 匹配描述，最长1024
        /// </summary>
        [JsonProperty("MatchDesc")]
        public string MatchDesc{ get; set; }

        /// <summary>
        /// 只支持https协议
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 游戏服务器队列地域
        /// </summary>
        [JsonProperty("ServerRegion")]
        public string ServerRegion{ get; set; }

        /// <summary>
        /// 游戏服务器队列
        /// </summary>
        [JsonProperty("ServerQueue")]
        public string ServerQueue{ get; set; }

        /// <summary>
        /// 自定义推送数据
        /// </summary>
        [JsonProperty("CustomPushData")]
        public string CustomPushData{ get; set; }

        /// <summary>
        /// 游戏服务器会话数据
        /// </summary>
        [JsonProperty("ServerSessionData")]
        public string ServerSessionData{ get; set; }

        /// <summary>
        /// 游戏属性，key-value结构的数组
        /// </summary>
        [JsonProperty("GameProperties")]
        public StringKV[] GameProperties{ get; set; }

        /// <summary>
        /// 日志开关，0表示关，1表示开
        /// </summary>
        [JsonProperty("LogSwitch")]
        public long? LogSwitch{ get; set; }

        /// <summary>
        /// 标签，key-value结构的数组
        /// </summary>
        [JsonProperty("Tags")]
        public StringKV[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchName", this.MatchName);
            this.SetParamSimple(map, prefix + "RuleCode", this.RuleCode);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "MatchDesc", this.MatchDesc);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "ServerRegion", this.ServerRegion);
            this.SetParamSimple(map, prefix + "ServerQueue", this.ServerQueue);
            this.SetParamSimple(map, prefix + "CustomPushData", this.CustomPushData);
            this.SetParamSimple(map, prefix + "ServerSessionData", this.ServerSessionData);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "LogSwitch", this.LogSwitch);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

