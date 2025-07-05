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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VersionData : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 固件版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtaVersion")]
        public string OtaVersion{ get; set; }

        /// <summary>
        /// 版本类型 1未发布 2测试发布 3正式发布 4禁用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PubStatus")]
        public ulong? PubStatus{ get; set; }

        /// <summary>
        /// 固件版本存储路径URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionUrl")]
        public string VersionUrl{ get; set; }

        /// <summary>
        /// 文件大小，byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 文件校验码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 指定的允许升级的旧版本，PubStatus=3时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldVersions")]
        public string OldVersions{ get; set; }

        /// <summary>
        /// 指定的允许升级的旧设备id，PubStatus=2时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tids")]
        public string Tids{ get; set; }

        /// <summary>
        /// 灰度值（0-100）,PubStatus=3时有效，表示n%的升级总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrayValue")]
        public ulong? GrayValue{ get; set; }

        /// <summary>
        /// 最近一次发布时间，UNIX时间戳，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishTime")]
        public ulong? PublishTime{ get; set; }

        /// <summary>
        /// 此版本激活的设备总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveCount")]
        public long? ActiveCount{ get; set; }

        /// <summary>
        /// 此版本在线的设备总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnlineCount")]
        public long? OnlineCount{ get; set; }

        /// <summary>
        /// 上传固件文件的时间，UNIX时间戳，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 发布记录的最后变更时间，UNIX时间戳，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UploadTime")]
        public ulong? UploadTime{ get; set; }

        /// <summary>
        /// 该固件版本发布的变更次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTimes")]
        public ulong? ModifyTimes{ get; set; }

        /// <summary>
        /// 备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 版本发布的描述信息，需要国际化，可以为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Contents")]
        public Contents Contents{ get; set; }

        /// <summary>
        /// 月活设备数，当月第一天开始有上线的设备数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliveInMonthCnt")]
        public ulong? AliveInMonthCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "OtaVersion", this.OtaVersion);
            this.SetParamSimple(map, prefix + "PubStatus", this.PubStatus);
            this.SetParamSimple(map, prefix + "VersionUrl", this.VersionUrl);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "OldVersions", this.OldVersions);
            this.SetParamSimple(map, prefix + "Tids", this.Tids);
            this.SetParamSimple(map, prefix + "GrayValue", this.GrayValue);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "ActiveCount", this.ActiveCount);
            this.SetParamSimple(map, prefix + "OnlineCount", this.OnlineCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UploadTime", this.UploadTime);
            this.SetParamSimple(map, prefix + "ModifyTimes", this.ModifyTimes);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "Contents.", this.Contents);
            this.SetParamSimple(map, prefix + "AliveInMonthCnt", this.AliveInMonthCnt);
        }
    }
}

