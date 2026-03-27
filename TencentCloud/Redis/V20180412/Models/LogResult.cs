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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogResult : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库ID</p>
        /// </summary>
        [JsonProperty("DBId")]
        public long? DBId{ get; set; }

        /// <summary>
        /// <p>命令延迟（毫秒）</p>
        /// </summary>
        [JsonProperty("CommandLatency")]
        public long? CommandLatency{ get; set; }

        /// <summary>
        /// <p>创建时间（格式：2006-01-02 15:04:05.000）</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>客户端地址</p>
        /// </summary>
        [JsonProperty("ClientAddr")]
        public string ClientAddr{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>命令类型</p>
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// <p>缓存代码，后端redis节点</p>
        /// </summary>
        [JsonProperty("CacheCode")]
        public string CacheCode{ get; set; }

        /// <summary>
        /// <p>命令详情</p>
        /// </summary>
        [JsonProperty("CommandDetail")]
        public string CommandDetail{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBId", this.DBId);
            this.SetParamSimple(map, prefix + "CommandLatency", this.CommandLatency);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ClientAddr", this.ClientAddr);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "CacheCode", this.CacheCode);
            this.SetParamSimple(map, prefix + "CommandDetail", this.CommandDetail);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
        }
    }
}

