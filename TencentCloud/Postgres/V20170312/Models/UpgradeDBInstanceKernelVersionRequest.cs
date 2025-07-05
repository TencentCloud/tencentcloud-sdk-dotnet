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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceKernelVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 升级的目标内核版本号。可以通过接口[DescribeDBVersions](https://cloud.tencent.com/document/api/409/89018)的返回字段AvailableUpgradeTarget获取。
        /// </summary>
        [JsonProperty("TargetDBKernelVersion")]
        public string TargetDBKernelVersion{ get; set; }

        /// <summary>
        /// 指定实例升级内核版本号完成后的切换时间。可选值:
        /// <li>0：立即切换
        /// <li>1：指定时间切换
        /// <li>2：维护时间窗口内切换
        /// 默认值：0 
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// 切换开始时间，时间格式：HH:MM:SS，例如：01:00:00。当SwitchTag为0或2时，该参数失效。
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// 切换截止时间，时间格式：HH:MM:SS，例如：01:30:00。当SwitchTag为0或2时，该参数失效。SwitchStartTime和SwitchEndTime时间窗口不能小于30分钟。
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }

        /// <summary>
        /// 是否对本次升级实例内核版本号操作执行预检查。
        /// <li>true：执行预检查操作，不升级内核版本号。检查项目包含请求参数、内核版本号兼容性、实例参数等。
        /// <li>false：发送正常请求（默认值），通过检查后直接升级内核版本号。
        /// 默认值：false
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDBKernelVersion", this.TargetDBKernelVersion);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

