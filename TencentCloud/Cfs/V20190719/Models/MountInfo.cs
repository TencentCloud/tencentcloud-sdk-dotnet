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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MountInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件系统 ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 挂载点 ID
        /// </summary>
        [JsonProperty("MountTargetId")]
        public string MountTargetId{ get; set; }

        /// <summary>
        /// 挂载点 IP
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// 挂载根目录
        /// </summary>
        [JsonProperty("FSID")]
        public string FSID{ get; set; }

        /// <summary>
        /// 挂载点状态，包括creating：创建中；available：运行中；
        /// deleting：删除中；
        /// create_failed： 创建失败
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// 网络类型，包括VPC,CCN
        /// </summary>
        [JsonProperty("NetworkInterface")]
        public string NetworkInterface{ get; set; }

        /// <summary>
        /// 私有网络 ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 子网 Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名称
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// CFS Turbo使用的云联网ID
        /// </summary>
        [JsonProperty("CcnID")]
        public string CcnID{ get; set; }

        /// <summary>
        /// 云联网中CFS Turbo使用的网段
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "MountTargetId", this.MountTargetId);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "FSID", this.FSID);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "NetworkInterface", this.NetworkInterface);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CcnID", this.CcnID);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
        }
    }
}

