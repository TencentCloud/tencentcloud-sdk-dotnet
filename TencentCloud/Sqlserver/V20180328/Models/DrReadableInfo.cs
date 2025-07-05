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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrReadableInfo : AbstractModel
    {
        
        /// <summary>
        /// 备机资源ID
        /// </summary>
        [JsonProperty("DrInstanceId")]
        public string DrInstanceId{ get; set; }

        /// <summary>
        /// 备机可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 备机状态
        /// DR_CREATING-备机创建中
        /// DR_RUNNING-备机运行中
        /// DR_UNAVAILABLE-备机不可用
        /// DR_ISOLATED-备机已隔离
        /// DR_RECYCLING-备机回收中
        /// DR_RECYCLED-备机已回收
        /// DR_JOB_RUNNING-备机执行任务中
        /// DR_OFFLINE-备机已下线
        /// DR_FAIL_OVER-备机只读故障转移中
        /// </summary>
        [JsonProperty("SlaveStatus")]
        public string SlaveStatus{ get; set; }

        /// <summary>
        /// 备机可读状态，enable-已开启，disable-已关闭
        /// </summary>
        [JsonProperty("ReadableStatus")]
        public string ReadableStatus{ get; set; }

        /// <summary>
        /// 备机只读vip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 备机只读端口
        /// </summary>
        [JsonProperty("VPort")]
        public long? VPort{ get; set; }

        /// <summary>
        /// 备机所在私有网络ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 备机所在私有网络子网ID
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 备机只读权重
        /// </summary>
        [JsonProperty("RoWeight")]
        public ulong? RoWeight{ get; set; }

        /// <summary>
        /// 备机只读模式，BalancedReadOnly-多备一读模式，SingleReadOnly-一备一读模式
        /// </summary>
        [JsonProperty("ReadMode")]
        public string ReadMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrInstanceId", this.DrInstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SlaveStatus", this.SlaveStatus);
            this.SetParamSimple(map, prefix + "ReadableStatus", this.ReadableStatus);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "RoWeight", this.RoWeight);
            this.SetParamSimple(map, prefix + "ReadMode", this.ReadMode);
        }
    }
}

