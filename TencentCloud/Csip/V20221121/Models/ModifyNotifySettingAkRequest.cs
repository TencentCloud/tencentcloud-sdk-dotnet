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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNotifySettingAkRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>告警类型/等级 (类型: AbnBehavior-异常行为, LeakDetect-泄露监测; 等级: 1-提示, 2-低危, 3-中危, 4-高危, 5-严重)</p>
        /// </summary>
        [JsonProperty("Alert")]
        public LevelOption[] Alert{ get; set; }

        /// <summary>
        /// <p>告警通知粒度</p><p>枚举值：</p><ul><li>0： 按告警聚合推送</li><li>1： 按调用记录推送</li></ul>
        /// </summary>
        [JsonProperty("AlertGranularity")]
        public long? AlertGranularity{ get; set; }

        /// <summary>
        /// <p>资产事件</p><p>枚举值：</p><ul><li>NewAk： AK新增</li></ul>
        /// </summary>
        [JsonProperty("Asset")]
        public string[] Asset{ get; set; }

        /// <summary>
        /// <p>通知开始时间</p><p>参数格式：hh:mm:ss</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>通知结束时间</p><p>参数格式：hh:mm:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Alert.", this.Alert);
            this.SetParamSimple(map, prefix + "AlertGranularity", this.AlertGranularity);
            this.SetParamArraySimple(map, prefix + "Asset.", this.Asset);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

