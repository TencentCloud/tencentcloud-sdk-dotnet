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

    public class CreateDLPFileDetectTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件下载Url
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件Md5
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 负载类型  1 从GroupId中选一节点 鉴定  2使用所有SelectNodeIds节点鉴定
        /// </summary>
        [JsonProperty("BalanceType")]
        public long? BalanceType{ get; set; }

        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 选中节点唯一Id列表,BalanceType=2时必填
        /// </summary>
        [JsonProperty("SelectNodeIds")]
        public string[] SelectNodeIds{ get; set; }

        /// <summary>
        /// 节点组唯一Id,BalanceType=1时必填
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "BalanceType", this.BalanceType);
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamArraySimple(map, prefix + "SelectNodeIds.", this.SelectNodeIds);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

