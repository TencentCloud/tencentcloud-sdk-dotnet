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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRansomDefenseStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 定时快照执行时间（0-23）：01:00;23:00
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// 策略ID，填ID时修改策略，否则新增策略
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 策略备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否开启：0关，1开
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否全部机器生效：0否，1是
        /// </summary>
        [JsonProperty("IsAll")]
        public ulong? IsAll{ get; set; }

        /// <summary>
        /// 包含目录，;分隔
        /// </summary>
        [JsonProperty("IncludeDir")]
        public string IncludeDir{ get; set; }

        /// <summary>
        /// 排除目录，;分隔
        /// </summary>
        [JsonProperty("ExcludeDir")]
        public string ExcludeDir{ get; set; }

        /// <summary>
        /// 备份模式： 0按周，1按天
        /// </summary>
        [JsonProperty("BackupType")]
        public ulong? BackupType{ get; set; }

        /// <summary>
        /// 定时任务执行星期天数（1-7）：1;2;7
        /// </summary>
        [JsonProperty("Weekday")]
        public string Weekday{ get; set; }

        /// <summary>
        /// 保留天数：0永久
        /// </summary>
        [JsonProperty("SaveDay")]
        public ulong? SaveDay{ get; set; }

        /// <summary>
        /// 绑定主机列表
        /// </summary>
        [JsonProperty("Machines")]
        public RansomDefenseStrategyMachineInfo[] Machines{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
            this.SetParamSimple(map, prefix + "IncludeDir", this.IncludeDir);
            this.SetParamSimple(map, prefix + "ExcludeDir", this.ExcludeDir);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "Weekday", this.Weekday);
            this.SetParamSimple(map, prefix + "SaveDay", this.SaveDay);
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
        }
    }
}

