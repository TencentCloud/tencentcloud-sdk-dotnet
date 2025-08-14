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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddClusterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，按照【集群ID】进行过滤，可通过调用[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已创建的集群列表或登录控制台进行查看；也可以调用[CreateCluster](https://cloud.tencent.com/document/product/649/36049)创建新的集群。仅在集群下无部署组、命名空间、云主机时可以删除。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 云主机ID列表，可通过调用[DescribeInstances](https://cloud.tencent.com/document/api/213/15728)查询已创建的云主机列表或登录控制台进行查看；也可以调用[RunInstances](https://cloud.tencent.com/document/api/213/15730)创建新的云主机。
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 操作系统镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 重装系统密码设置
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 重装系统，关联密钥设置
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 安全组设置
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// 云主机导入方式，虚拟机集群必填，容器集群不填写此字段，R：重装TSF系统镜像，M：手动安装agent
        /// </summary>
        [JsonProperty("InstanceImportMode")]
        public string InstanceImportMode{ get; set; }

        /// <summary>
        /// 镜像定制类型
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// 镜像特征ID列表
        /// </summary>
        [JsonProperty("FeatureIdList")]
        public string[] FeatureIdList{ get; set; }

        /// <summary>
        /// 实例额外需要设置参数信息
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// 安全组 ID 列表
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "SgId", this.SgId);
            this.SetParamSimple(map, prefix + "InstanceImportMode", this.InstanceImportMode);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamArraySimple(map, prefix + "FeatureIdList.", this.FeatureIdList);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

