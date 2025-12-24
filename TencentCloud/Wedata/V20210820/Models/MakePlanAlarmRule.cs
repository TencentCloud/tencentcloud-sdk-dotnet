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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MakePlanAlarmRule : AbstractModel
    {
        
        /// <summary>
        /// 告警的级别
        /// 1 -- 普通
        /// 2 -- 重要
        /// 3 -- 紧急
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public long? AlarmLevel{ get; set; }

        /// <summary>
        /// 告警的类型，补录计划支持：
        /// start：启动告警
        /// failure：失败告警
        /// success：成功告警
        /// overtime：超过配置时间告警
        /// </summary>
        [JsonProperty("AlarmTypes")]
        public string[] AlarmTypes{ get; set; }

        /// <summary>
        /// 告警超时时间
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// 告警接受人 升级人配置信息
        /// </summary>
        [JsonProperty("AlarmGroup")]
        public AlarmGroup[] AlarmGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArraySimple(map, prefix + "AlarmTypes.", this.AlarmTypes);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamArrayObj(map, prefix + "AlarmGroup.", this.AlarmGroup);
        }
    }
}

