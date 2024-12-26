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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UebaCustomRule : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 1: 云账号
        /// 2: 自定义用户
        /// </summary>
        [JsonProperty("UserType")]
        public long? UserType{ get; set; }

        /// <summary>
        /// 发生时间
        /// 1：10分钟
        /// 2：1小时
        /// 3：一天
        /// 4：一周
        /// 5：一个月
        /// </summary>
        [JsonProperty("TimeInterval")]
        public long? TimeInterval{ get; set; }

        /// <summary>
        /// 发生事件
        /// </summary>
        [JsonProperty("EventContent")]
        public UebaEventContent EventContent{ get; set; }

        /// <summary>
        /// 告警名称
        /// </summary>
        [JsonProperty("AlertName")]
        public string AlertName{ get; set; }

        /// <summary>
        /// 告警类型
        /// 0:  提示
        /// 1:  低危
        /// 2:  中危
        /// 3:  高危
        /// 4:  严重
        /// </summary>
        [JsonProperty("AlterLevel")]
        public long? AlterLevel{ get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        [JsonProperty("Operator")]
        public string[] Operator{ get; set; }

        /// <summary>
        /// 操作对象
        /// </summary>
        [JsonProperty("OperateObject")]
        public string[] OperateObject{ get; set; }

        /// <summary>
        /// 操作方式
        /// </summary>
        [JsonProperty("OperateMethod")]
        public string[] OperateMethod{ get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 日志中文名
        /// </summary>
        [JsonProperty("LogTypeStr")]
        public string LogTypeStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "TimeInterval", this.TimeInterval);
            this.SetParamObj(map, prefix + "EventContent.", this.EventContent);
            this.SetParamSimple(map, prefix + "AlertName", this.AlertName);
            this.SetParamSimple(map, prefix + "AlterLevel", this.AlterLevel);
            this.SetParamArraySimple(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "OperateObject.", this.OperateObject);
            this.SetParamArraySimple(map, prefix + "OperateMethod.", this.OperateMethod);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogTypeStr", this.LogTypeStr);
        }
    }
}

