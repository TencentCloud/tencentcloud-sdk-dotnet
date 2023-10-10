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

    public class RansomDefenseEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// cvm uuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 事件状态 0待处理，1已处理，2已信任，3处理中，4已恢复备份
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 被篡改文件路径
        /// </summary>
        [JsonProperty("BaitFilePath")]
        public string BaitFilePath{ get; set; }

        /// <summary>
        /// 恶意文件路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 恶意进程id
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// 恶意进程参数
        /// </summary>
        [JsonProperty("PidParam")]
        public string PidParam{ get; set; }

        /// <summary>
        /// 恶意文件大小
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 恶意文件md5
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 事件类型：0加密勒索，1文件篡改
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 事件发送时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// cvm 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 事件修改事件
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 主机外网ip
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 主机内网ip
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 进程树 base64 json
        /// </summary>
        [JsonProperty("PsTree")]
        public string PsTree{ get; set; }

        /// <summary>
        /// 进程启动时间
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public string ProcessStartTime{ get; set; }

        /// <summary>
        /// 主机拥有快照备份数
        /// </summary>
        [JsonProperty("SnapshotNum")]
        public ulong? SnapshotNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BaitFilePath", this.BaitFilePath);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "PidParam", this.PidParam);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "PsTree", this.PsTree);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "SnapshotNum", this.SnapshotNum);
        }
    }
}

