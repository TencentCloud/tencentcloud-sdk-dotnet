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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceHardwareInfoItem : AbstractModel
    {
        
        /// <summary>
        /// <p>设备ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>设备唯一标识符</p>
        /// </summary>
        [JsonProperty("Mid")]
        public string Mid{ get; set; }

        /// <summary>
        /// <p>OS平台 0 Windows 1 Linux 2 macOS 4 Android 5 iOS</p>
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// <p>终端名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>终端用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>授权状态（ 4未授权 5已授权）</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>设备所属分组ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>设备所属分组名</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>设备所属分组路径</p>
        /// </summary>
        [JsonProperty("GroupNamePath")]
        public string GroupNamePath{ get; set; }

        /// <summary>
        /// <p>最近登录账户的姓名</p>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>出口IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>MAC地址</p>
        /// </summary>
        [JsonProperty("MacAddr")]
        public string MacAddr{ get; set; }

        /// <summary>
        /// <p>CPU品牌型号</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// <p>内存信息</p>
        /// </summary>
        [JsonProperty("Memory")]
        public string Memory{ get; set; }

        /// <summary>
        /// <p>硬盘信息</p>
        /// </summary>
        [JsonProperty("HardDiskSize")]
        public string HardDiskSize{ get; set; }

        /// <summary>
        /// <p>显示器品牌型号</p>
        /// </summary>
        [JsonProperty("Monitor")]
        public string Monitor{ get; set; }

        /// <summary>
        /// <p>终端备注名</p>
        /// </summary>
        [JsonProperty("RemarkName")]
        public string RemarkName{ get; set; }

        /// <summary>
        /// <p>BiosUUID（启动盘标识符）</p>
        /// </summary>
        [JsonProperty("BiosUuid")]
        public string BiosUuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Mid", this.Mid);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupNamePath", this.GroupNamePath);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "MacAddr", this.MacAddr);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "HardDiskSize", this.HardDiskSize);
            this.SetParamSimple(map, prefix + "Monitor", this.Monitor);
            this.SetParamSimple(map, prefix + "RemarkName", this.RemarkName);
            this.SetParamSimple(map, prefix + "BiosUuid", this.BiosUuid);
        }
    }
}

