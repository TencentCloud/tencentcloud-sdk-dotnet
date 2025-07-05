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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliverTypeDetails : AbstractModel
    {
        
        /// <summary>
        /// 安全模块类型 1: 入侵检测 2: 漏洞管理 3: 基线管理 4: 高级防御 5:客户端相关 6: 资产指纹 7 主机列表 8 客户端上报
        /// </summary>
        [JsonProperty("SecurityType")]
        public ulong? SecurityType{ get; set; }

        /// <summary>
        /// 安全模块下的日志类型
        /// </summary>
        [JsonProperty("LogType")]
        public long?[] LogType{ get; set; }

        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 主题名
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 投递开关 0关闭 1开启
        /// </summary>
        [JsonProperty("Switch")]
        public ulong? Switch{ get; set; }

        /// <summary>
        /// 投递状态，0未开启 1正常 2异常
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }

        /// <summary>
        /// 最近一次状态上报时间戳
        /// </summary>
        [JsonProperty("StatusTime")]
        public long? StatusTime{ get; set; }

        /// <summary>
        /// 日志集名
        /// </summary>
        [JsonProperty("LogName")]
        public string LogName{ get; set; }

        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 日志集所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamArraySimple(map, prefix + "LogType.", this.LogType);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
            this.SetParamSimple(map, prefix + "StatusTime", this.StatusTime);
            this.SetParamSimple(map, prefix + "LogName", this.LogName);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

