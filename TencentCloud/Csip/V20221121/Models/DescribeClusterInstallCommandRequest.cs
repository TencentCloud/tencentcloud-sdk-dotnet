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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterInstallCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否腾讯云。true：走平行容器 daemonset yaml 安装分支；false：走主机 agent 安装命令分支</p>
        /// </summary>
        [JsonProperty("IsCloud")]
        public bool? IsCloud{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>网络类型<br>枚举值：<br>basic：基础网络<br>private：VPC<br>public：公网<br>direct：专线</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>地域编码（NetType=direct 时必填；腾讯云分支用于特殊地域镜像仓库替换）</p>
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// <p>VPC ID（NetType=direct 时必填）<br>参数格式：形如 vpc-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>过期时间<br>参数格式：yyyy-MM-dd（如 2026-12-31）<br>用途：腾讯云分支用于 daemonset yaml 的 cos 下载链接过期时间；非腾讯云分支用于 agent 安装 token 过期时间</p>
        /// </summary>
        [JsonProperty("ExpireDate")]
        public string ExpireDate{ get; set; }

        /// <summary>
        /// <p>csip 标签 ID 列表（非腾讯云分支用，关联安装标签）</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }

        /// <summary>
        /// <p>集群自定义参数（腾讯云分支用于替换 daemonset 模板占位符）</p>
        /// </summary>
        [JsonProperty("ClusterCustomParameters")]
        public ClusterCustomParameters[] ClusterCustomParameters{ get; set; }

        /// <summary>
        /// <p>接入 VIP（非腾讯云分支用；NetType=direct 且未传 Vip 时由专线服务自动申请）</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ExpireDate", this.ExpireDate);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArrayObj(map, prefix + "ClusterCustomParameters.", this.ClusterCustomParameters);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

