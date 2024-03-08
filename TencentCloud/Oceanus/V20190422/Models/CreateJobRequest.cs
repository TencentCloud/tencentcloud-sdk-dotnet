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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业名称，允许输入长度小于等于50个字符的中文、英文、数字、-（横线）、_（下划线）、.（点），且符号必须半角字符。注意作业名不能和现有作业同名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 作业的类型，1 表示 SQL 作业，2 表示 JAR 作业
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// 集群的类型，1 表示共享集群，2 表示独享集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// 当 ClusterType=2 时，必选，用来指定该作业提交的独享集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 设置每 CU 的内存规格，单位为 GB，支持 2、4、8、16（需申请开通白名单后使用）。默认为 4，即 1 CU 对应 4 GB 的运行内存
        /// </summary>
        [JsonProperty("CuMem")]
        public ulong? CuMem{ get; set; }

        /// <summary>
        /// 作业的备注信息，可以随意设置
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 作业名所属文件夹ID，根目录为"root"
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 作业运行的Flink版本
        /// </summary>
        [JsonProperty("FlinkVersion")]
        public string FlinkVersion{ get; set; }

        /// <summary>
        /// 工作空间 SerialId
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// 作业标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 作业描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "CuMem", this.CuMem);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FlinkVersion", this.FlinkVersion);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

