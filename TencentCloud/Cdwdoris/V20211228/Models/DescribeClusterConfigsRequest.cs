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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterConfigsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        ///  0 公有云查询；1青鹅查询，青鹅查询显示所有需要展示的
        /// </summary>
        [JsonProperty("ConfigType")]
        public long? ConfigType{ get; set; }

        /// <summary>
        /// 模糊搜索关键字文件
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 0集群维度 1节点维度 2启动脚本 3计算组维度
        /// </summary>
        [JsonProperty("ClusterConfigType")]
        public long? ClusterConfigType{ get; set; }

        /// <summary>
        /// eth0的ip地址
        /// </summary>
        [JsonProperty("IPAddress")]
        public string IPAddress{ get; set; }

        /// <summary>
        /// 计算组id
        /// </summary>
        [JsonProperty("ComputeGroupId")]
        public string ComputeGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ClusterConfigType", this.ClusterConfigType);
            this.SetParamSimple(map, prefix + "IPAddress", this.IPAddress);
            this.SetParamSimple(map, prefix + "ComputeGroupId", this.ComputeGroupId);
        }
    }
}

