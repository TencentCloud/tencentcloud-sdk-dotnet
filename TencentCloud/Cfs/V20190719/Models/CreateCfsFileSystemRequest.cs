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

    public class CreateCfsFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>可用区名称</p><p>取值参考：<a href="https://cloud.tencent.com/document/product/213/15707?">查询可用区列表</a></p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>网络类型</p><p>枚举值：</p><ul><li><p>VPC： 私有网络</p></li><li><p>CCN： 云联网</p></li><li><p>通用标准型/性能型（含增强型）、吞吐型请选择VPC</p></li><li><p>Turbo标准型/性能型可选VPC或CCN</p></li><li><p>当 Scenario=AgentSandbox 时，即创建 AgentCFS时无需传入，传入将被忽略。</p></li></ul>
        /// </summary>
        [JsonProperty("NetInterface")]
        public string NetInterface{ get; set; }

        /// <summary>
        /// <p>权限组 ID。权限组规定了一组可来访白名单及操作权限。</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/582/38157">DescribeCfsPGroups</a></p><ul><li>pgroupbasic 为【默认权限组】，【默认权限组】允许所有IP地址访问及读写权限。 </li><li>注意：当 Scenario=AgentSandbox 时，即创建 AgentCFS ，必须传入 pgroupbasic【默认权限组】，传其他值报错。</li></ul>
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// <p>文件系统协议类型</p><p>枚举值：</p><ul><li>NFS： 通用标准型（含增强型）、通用性能型（含增强型）支持创建此协议的实例</li><li>CIFS： 即SMB协议，仅部分可用区的通用标准型、吞吐型支持此协议。</li><li>TURBO： Turbo标准型/Turbo性能型/AgentCFS是支持创建此协议的实例</li></ul><p>默认值：NFS</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>文件系统存储类型其中 SD 为通用标准型存储， HP为通用性能型存储， TB为Turbo标准型， TP 为Turbo性能型。</p><p>枚举值：</p><ul><li>SD： 通用标准型（含增强型）。通用标准型 version = v1.5，通用标准型（增强型） version = v3.1。</li><li>HP： 通用性能型（含增强型）。通用性能型 version = v1.5，通用性能型（增强型） version = v3.1。</li><li>TB： Turbo标准型</li><li>TP： Turbo性能型</li><li>THP： 吞吐型</li></ul><p>默认值：SD</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>私有网络（VPC） ID，若网络类型选择的是VPC，该字段为必填。</p><p>取值参考：<a href="https://cloud.tencent.com/document/product/215/15778">查询VPC列表</a></p><p>当 Scenario=AgentSandbox 时，即创建 AgentCFS 时无需传入，传入将被忽略。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID，若网络类型选择的是VPC，该字段为必填。</p><p>取值参考：<a href="https://cloud.tencent.com/document/product/215/15784">查询子网列表</a></p><p>当 Scenario=AgentSandbox 时，即创建 AgentCFS 时无需传入，传入将被忽略。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>指定IP地址，仅VPC网络支持；若不填写、将在该子网下随机分配 IP，Turbo系列当前不支持指定</p>
        /// </summary>
        [JsonProperty("MountIP")]
        public string MountIP{ get; set; }

        /// <summary>
        /// <p>用户自定义文件系统名称</p>
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// <p>文件系统是否加密，若留空则默认为不加密</p>
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// <p>文件系统标签</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。用于保证请求幂等性的字符串失效时间为2小时。</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>云联网ID， 若网络类型选择的是CCN，该字段为必填</p><p>取值参考：<a href="https://cloud.tencent.com/document/product/215/19199">查询CCN列表</a></p><p>当 Scenario=AgentSandbox 时，即创建 AgentCFS 时无需传入，传入将被忽略</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>云联网中CFS使用的网段， 若网络类型选择的是CCN，该字段为必填，且不能和Ccn中已经绑定的网段冲突</p><p>当 Scenario=AgentSandbox 时，即创建 AgentCFS 时无需传入，传入将被忽略</p>
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// <p>文件系统容量，turbo系列必填</p><p>单位：GiB</p><p>Turbo标准型起售20TiB，即20480 GiB，扩容步长10TiB，即10240 GiB。Turbo性能型起售10TiB，即10240 GiB，扩容步长10TiB，即10240 GiB。</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// <p>文件系统快照 ID</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/582/80206">DescribeCfsSnapshots</a></p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>定期快照策略 ID</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/582/80208">DescribeAutoSnapshotPolicies</a></p>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// <p>是否开启自动扩容策略，仅turbo类型文件存储支持</p>
        /// </summary>
        [JsonProperty("EnableAutoScaleUp")]
        public bool? EnableAutoScaleUp{ get; set; }

        /// <summary>
        /// <p>文件系统版本号。</p><p>枚举值：</p><ul><li>v1.5： 创建通用标准型/通用性能型文件系统</li><li>v3.1： 创建通用标准型（增强型）/通用性能型（增强型）文件系统，如需创建增强型，此为必填项。</li><li>v4.0： 创建Turbo标准型、Turbo性能型、吞吐型文件系统，非必填项</li></ul><p>创建通用标准型（增强型）、通用性能型（增强型）须加白主账号，如需使用请联系我们。</p>
        /// </summary>
        [JsonProperty("CfsVersion")]
        public string CfsVersion{ get; set; }

        /// <summary>
        /// <p>turbo文件系统元数据类型</p><p>枚举值：</p><ul><li>basic： 创建标准版元数据。</li><li>enhanced： 创建增强版元数据</li></ul><p>详情参见<a href="https://cloud.tencent.com/document/product/582/116836">Turbo 文件系统元数据类型</a></p>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>业务场景。</p><p>枚举值：</p><ul><li>AgentSandbox： 创建 AgentCFS 时必传</li></ul>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetInterface", this.NetInterface);
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MountIP", this.MountIP);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "EnableAutoScaleUp", this.EnableAutoScaleUp);
            this.SetParamSimple(map, prefix + "CfsVersion", this.CfsVersion);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
        }
    }
}

