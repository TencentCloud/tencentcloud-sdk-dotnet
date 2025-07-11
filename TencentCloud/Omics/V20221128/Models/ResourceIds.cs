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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceIds : AbstractModel
    {
        
        /// <summary>
        /// 私有网络ID。
        /// </summary>
        [JsonProperty("VPCId")]
        public string VPCId{ get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// TDSQL-C Mysql版数据库ID。
        /// </summary>
        [JsonProperty("TDSQLCId")]
        public string TDSQLCId{ get; set; }

        /// <summary>
        /// 文件存储ID。
        /// </summary>
        [JsonProperty("CFSId")]
        public string CFSId{ get; set; }

        /// <summary>
        /// 文件存储类型：取值范围：
        /// - SD：通用标准型
        /// - HP：通用性能型
        /// - TB：turbo标准型
        /// - TP：turbo性能型
        /// </summary>
        [JsonProperty("CFSStorageType")]
        public string CFSStorageType{ get; set; }

        /// <summary>
        /// 云服务器ID。
        /// </summary>
        [JsonProperty("CVMId")]
        public string CVMId{ get; set; }

        /// <summary>
        /// 弹性容器集群ID。
        /// </summary>
        [JsonProperty("EKSId")]
        public string EKSId{ get; set; }

        /// <summary>
        /// TKE容器集群ID。
        /// </summary>
        [JsonProperty("TKEId")]
        public string TKEId{ get; set; }

        /// <summary>
        /// TKE系统节点池ID。
        /// </summary>
        [JsonProperty("TKESystemNodePoolId")]
        public string TKESystemNodePoolId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VPCId", this.VPCId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "TDSQLCId", this.TDSQLCId);
            this.SetParamSimple(map, prefix + "CFSId", this.CFSId);
            this.SetParamSimple(map, prefix + "CFSStorageType", this.CFSStorageType);
            this.SetParamSimple(map, prefix + "CVMId", this.CVMId);
            this.SetParamSimple(map, prefix + "EKSId", this.EKSId);
            this.SetParamSimple(map, prefix + "TKEId", this.TKEId);
            this.SetParamSimple(map, prefix + "TKESystemNodePoolId", this.TKESystemNodePoolId);
        }
    }
}

