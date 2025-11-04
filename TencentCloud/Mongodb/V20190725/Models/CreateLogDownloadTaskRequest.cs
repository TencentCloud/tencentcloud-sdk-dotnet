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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLogDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// 日志类别
        /// </summary>
        [JsonProperty("LogComponents")]
        public string[] LogComponents{ get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        [JsonProperty("LogLevels")]
        public string[] LogLevels{ get; set; }

        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("LogIds")]
        public string[] LogIds{ get; set; }

        /// <summary>
        /// 日志连接信息
        /// </summary>
        [JsonProperty("LogConnections")]
        public string[] LogConnections{ get; set; }

        /// <summary>
        /// 日志详情过滤字段
        /// </summary>
        [JsonProperty("LogDetailParams")]
        public string[] LogDetailParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamArraySimple(map, prefix + "LogComponents.", this.LogComponents);
            this.SetParamArraySimple(map, prefix + "LogLevels.", this.LogLevels);
            this.SetParamArraySimple(map, prefix + "LogIds.", this.LogIds);
            this.SetParamArraySimple(map, prefix + "LogConnections.", this.LogConnections);
            this.SetParamArraySimple(map, prefix + "LogDetailParams.", this.LogDetailParams);
        }
    }
}

