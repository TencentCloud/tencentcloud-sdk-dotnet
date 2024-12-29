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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// EMR集群实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 需要挂载的云盘ID
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 挂载模式，取值范围：
        /// AUTO_RENEW：自动续费
        /// ALIGN_DEADLINE：自动对其到期时间
        /// </summary>
        [JsonProperty("AlignType")]
        public string AlignType{ get; set; }

        /// <summary>
        /// 需要挂载的cvm节点id列表
        /// </summary>
        [JsonProperty("CvmInstanceIds")]
        public string[] CvmInstanceIds{ get; set; }

        /// <summary>
        /// 是否是新购云盘进行挂载
        /// </summary>
        [JsonProperty("CreateDisk")]
        public bool? CreateDisk{ get; set; }

        /// <summary>
        /// 新购云盘规格
        /// </summary>
        [JsonProperty("DiskSpec")]
        public NodeSpecDiskV2 DiskSpec{ get; set; }

        /// <summary>
        /// 可选参数，不传该参数则仅执行挂载操作。传入True时，会在挂载成功后将云硬盘设置为随云主机销毁模式，仅对按量计费云硬盘有效。
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "AlignType", this.AlignType);
            this.SetParamArraySimple(map, prefix + "CvmInstanceIds.", this.CvmInstanceIds);
            this.SetParamSimple(map, prefix + "CreateDisk", this.CreateDisk);
            this.SetParamObj(map, prefix + "DiskSpec.", this.DiskSpec);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
        }
    }
}

