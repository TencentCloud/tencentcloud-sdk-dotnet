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

    public class FileSystemInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// <p>用户自定义名称</p>
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// <p>文件系统 ID</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>文件系统状态。取值范围：</p><ul><li>creating:创建中</li><li>mounting:挂载中</li><li>create_failed:创建失败</li><li>available:可使用</li><li>unserviced:停服中</li><li>upgrading:升级中</li></ul>
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// <p>文件系统已使用容量。单位：Byte</p>
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// <p>文件系统空间限制。单位:GiB</p>
        /// </summary>
        [JsonProperty("SizeLimit")]
        public ulong? SizeLimit{ get; set; }

        /// <summary>
        /// <p>区域 ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>区域名称</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>文件系统协议类型, 支持 NFS,CIFS,TURBO</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>存储类型，HP：通用性能型；SD：通用标准型；TP:turbo性能型；TB：turbo标准型；THP：吞吐型</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>文件系统绑定的预付费存储包</p>
        /// </summary>
        [JsonProperty("StorageResourcePkg")]
        public string StorageResourcePkg{ get; set; }

        /// <summary>
        /// <p>文件系统绑定的预付费带宽包（暂未支持）</p>
        /// </summary>
        [JsonProperty("BandwidthResourcePkg")]
        public string BandwidthResourcePkg{ get; set; }

        /// <summary>
        /// <p>文件系统绑定权限组信息</p>
        /// </summary>
        [JsonProperty("PGroup")]
        public PGroup PGroup{ get; set; }

        /// <summary>
        /// <p>用户自定义名称</p>
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// <p>文件系统是否加密,true：代表加密，false：非加密</p>
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// <p>加密所使用的密钥，可以为密钥的 ID 或者 ARN</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>文件系统吞吐上限，吞吐上限是根据文件系统当前已使用存储量、绑定的存储资源包以及吞吐资源包一同确定. 单位MiB/s</p>
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public float? BandwidthLimit{ get; set; }

        /// <summary>
        /// <p>文件系统关联的快照策略</p>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// <p>文件系统处理快照状态,snapping：快照中，normal：正常状态</p>
        /// </summary>
        [JsonProperty("SnapStatus")]
        public string SnapStatus{ get; set; }

        /// <summary>
        /// <p>文件系统容量规格上限<br>单位:GiB</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// <p>文件系统标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>文件系统生命周期管理状态<br>NotAvailable：不可用<br>Available:可用</p>
        /// </summary>
        [JsonProperty("TieringState")]
        public string TieringState{ get; set; }

        /// <summary>
        /// <p>分层存储详情</p>
        /// </summary>
        [JsonProperty("TieringDetail")]
        public TieringDetailInfo TieringDetail{ get; set; }

        /// <summary>
        /// <p>文件系统自动扩容策略</p>
        /// </summary>
        [JsonProperty("AutoScaleUpRule")]
        public AutoScaleUpRule AutoScaleUpRule{ get; set; }

        /// <summary>
        /// <p>文件系统版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>额外性能信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExstraPerformanceInfo")]
        public ExstraPerformanceInfo[] ExstraPerformanceInfo{ get; set; }

        /// <summary>
        /// <p>basic：标准版元数据类型<br>enhanced：增项版元数据类型</p>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>业务场景。</p><p>枚举值：</p><ul><li>AgentSandbox： 创建 AgentCFS</li></ul>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "SizeLimit", this.SizeLimit);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageResourcePkg", this.StorageResourcePkg);
            this.SetParamSimple(map, prefix + "BandwidthResourcePkg", this.BandwidthResourcePkg);
            this.SetParamObj(map, prefix + "PGroup.", this.PGroup);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "SnapStatus", this.SnapStatus);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TieringState", this.TieringState);
            this.SetParamObj(map, prefix + "TieringDetail.", this.TieringDetail);
            this.SetParamObj(map, prefix + "AutoScaleUpRule.", this.AutoScaleUpRule);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "ExstraPerformanceInfo.", this.ExstraPerformanceInfo);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
        }
    }
}

