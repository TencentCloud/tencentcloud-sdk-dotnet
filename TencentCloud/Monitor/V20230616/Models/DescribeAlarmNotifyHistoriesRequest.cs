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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmNotifyHistoriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// 起始时间点，unix秒级时间戳
        /// </summary>
        [JsonProperty("QueryBaseTime")]
        public long? QueryBaseTime{ get; set; }

        /// <summary>
        /// 从 QueryBaseTime 开始，需要查询往前多久的时间，单位秒
        /// </summary>
        [JsonProperty("QueryBeforeSeconds")]
        public long? QueryBeforeSeconds{ get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [JsonProperty("PageParams")]
        public PageByNoParams PageParams{ get; set; }

        /// <summary>
        /// 当监控类型为 MT_QCE 时候需要填写，归属的命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 当监控类型为 MT_QCE 时候需要填写， 告警策略类型
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 查询某个策略的通知历史
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "QueryBaseTime", this.QueryBaseTime);
            this.SetParamSimple(map, prefix + "QueryBeforeSeconds", this.QueryBeforeSeconds);
            this.SetParamObj(map, prefix + "PageParams.", this.PageParams);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
        }
    }
}

