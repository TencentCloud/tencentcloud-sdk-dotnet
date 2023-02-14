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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRepository : AbstractModel
    {
        
        /// <summary>
        /// 仓库名,含命名空间,如tsf/nginx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reponame")]
        public string Reponame{ get; set; }

        /// <summary>
        /// 仓库类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Repotype")]
        public string Repotype{ get; set; }

        /// <summary>
        /// 镜像版本数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagCount")]
        public long? TagCount{ get; set; }

        /// <summary>
        /// 是否公共,1:公有,0:私有
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPublic")]
        public long? IsPublic{ get; set; }

        /// <summary>
        /// 是否被用户收藏。true：是，false：否
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsUserFavor")]
        public bool? IsUserFavor{ get; set; }

        /// <summary>
        /// 是否是腾讯云官方仓库。 是否是腾讯云官方仓库。true：是，false：否
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsQcloudOfficial")]
        public bool? IsQcloudOfficial{ get; set; }

        /// <summary>
        /// 被所有用户收藏次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FavorCount")]
        public long? FavorCount{ get; set; }

        /// <summary>
        /// 拉取次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullCount")]
        public long? PullCount{ get; set; }

        /// <summary>
        /// 描述内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// TcrRepoInfo值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcrRepoInfo")]
        public TcrRepoInfo TcrRepoInfo{ get; set; }

        /// <summary>
        /// TcrBindingId值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcrBindingId")]
        public long? TcrBindingId{ get; set; }

        /// <summary>
        /// applicationid值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// ApplicationName值（废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public ScalableRule ApplicationName{ get; set; }

        /// <summary>
        /// ApplicationName值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationNameReal")]
        public string ApplicationNameReal{ get; set; }

        /// <summary>
        /// 是否公共,1:公有,0:私有
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Public")]
        public long? Public{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Reponame", this.Reponame);
            this.SetParamSimple(map, prefix + "Repotype", this.Repotype);
            this.SetParamSimple(map, prefix + "TagCount", this.TagCount);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "IsUserFavor", this.IsUserFavor);
            this.SetParamSimple(map, prefix + "IsQcloudOfficial", this.IsQcloudOfficial);
            this.SetParamSimple(map, prefix + "FavorCount", this.FavorCount);
            this.SetParamSimple(map, prefix + "PullCount", this.PullCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "TcrRepoInfo.", this.TcrRepoInfo);
            this.SetParamSimple(map, prefix + "TcrBindingId", this.TcrBindingId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamObj(map, prefix + "ApplicationName.", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationNameReal", this.ApplicationNameReal);
            this.SetParamSimple(map, prefix + "Public", this.Public);
        }
    }
}

