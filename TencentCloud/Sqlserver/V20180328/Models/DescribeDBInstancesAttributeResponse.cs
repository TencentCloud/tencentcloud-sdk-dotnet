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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesAttributeResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 定期备份状态 enable-开启，disable-关闭
        /// </summary>
        [JsonProperty("RegularBackupEnable")]
        public string RegularBackupEnable{ get; set; }

        /// <summary>
        /// 定期备份保留天数 [90 - 3650]天
        /// </summary>
        [JsonProperty("RegularBackupSaveDays")]
        public ulong? RegularBackupSaveDays{ get; set; }

        /// <summary>
        /// 定期备份策略 years-每年，quarters-每季度，months-每月
        /// </summary>
        [JsonProperty("RegularBackupStrategy")]
        public string RegularBackupStrategy{ get; set; }

        /// <summary>
        /// 定期备份保留个数
        /// </summary>
        [JsonProperty("RegularBackupCounts")]
        public ulong? RegularBackupCounts{ get; set; }

        /// <summary>
        /// 定期备份开始日期，格式-YYYY-MM-DD 默认当前日期
        /// </summary>
        [JsonProperty("RegularBackupStartTime")]
        public string RegularBackupStartTime{ get; set; }

        /// <summary>
        /// 阻塞进程阈值，单位毫秒
        /// </summary>
        [JsonProperty("BlockedThreshold")]
        public long? BlockedThreshold{ get; set; }

        /// <summary>
        /// 慢SQL、阻塞、死锁扩展事件文件保留时长
        /// </summary>
        [JsonProperty("EventSaveDays")]
        public long? EventSaveDays{ get; set; }

        /// <summary>
        /// TDE透明数据加密配置
        /// </summary>
        [JsonProperty("TDEConfig")]
        public TDEConfigAttribute TDEConfig{ get; set; }

        /// <summary>
        /// SSL加密
        /// </summary>
        [JsonProperty("SSLConfig")]
        public SSLConfig SSLConfig{ get; set; }

        /// <summary>
        /// 备机只读信息
        /// </summary>
        [JsonProperty("DrReadableInfo")]
        public DrReadableInfo DrReadableInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RegularBackupEnable", this.RegularBackupEnable);
            this.SetParamSimple(map, prefix + "RegularBackupSaveDays", this.RegularBackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupStrategy", this.RegularBackupStrategy);
            this.SetParamSimple(map, prefix + "RegularBackupCounts", this.RegularBackupCounts);
            this.SetParamSimple(map, prefix + "RegularBackupStartTime", this.RegularBackupStartTime);
            this.SetParamSimple(map, prefix + "BlockedThreshold", this.BlockedThreshold);
            this.SetParamSimple(map, prefix + "EventSaveDays", this.EventSaveDays);
            this.SetParamObj(map, prefix + "TDEConfig.", this.TDEConfig);
            this.SetParamObj(map, prefix + "SSLConfig.", this.SSLConfig);
            this.SetParamObj(map, prefix + "DrReadableInfo.", this.DrReadableInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

