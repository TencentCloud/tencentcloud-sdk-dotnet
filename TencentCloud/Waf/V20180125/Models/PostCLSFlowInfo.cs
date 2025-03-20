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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PostCLSFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 投递流唯一ID
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// 1-访问日志 2-攻击日志
        /// </summary>
        [JsonProperty("LogType")]
        public long? LogType{ get; set; }

        /// <summary>
        /// 状态 0-为关闭 1-为启用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// CLS所在区域
        /// </summary>
        [JsonProperty("CLSRegion")]
        public string CLSRegion{ get; set; }

        /// <summary>
        /// CLS日志集合名称
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// CLS日志集合ID
        /// </summary>
        [JsonProperty("LogsetID")]
        public string LogsetID{ get; set; }

        /// <summary>
        /// CLS日志主题名称
        /// </summary>
        [JsonProperty("LogTopicName")]
        public string LogTopicName{ get; set; }

        /// <summary>
        /// CLS日志集合ID
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CLSRegion", this.CLSRegion);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "LogsetID", this.LogsetID);
            this.SetParamSimple(map, prefix + "LogTopicName", this.LogTopicName);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
        }
    }
}

