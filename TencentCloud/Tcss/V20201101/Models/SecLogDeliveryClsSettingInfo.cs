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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecLogDeliveryClsSettingInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志类型
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 投递状态(true:开启 false:关闭)
        /// </summary>
        [JsonProperty("State")]
        public bool? State{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 日志集
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("TopicID")]
        public string TopicID{ get; set; }

        /// <summary>
        /// 日志集名称
        /// </summary>
        [JsonProperty("LogSetName")]
        public string LogSetName{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 日志类型	
        /// </summary>
        [JsonProperty("SubLogType")]
        public string[] SubLogType{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "TopicID", this.TopicID);
            this.SetParamSimple(map, prefix + "LogSetName", this.LogSetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamArraySimple(map, prefix + "SubLogType.", this.SubLogType);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
        }
    }
}

