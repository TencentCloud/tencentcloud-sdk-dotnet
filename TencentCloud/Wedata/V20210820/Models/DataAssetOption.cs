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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataAssetOption : AbstractModel
    {
        
        /// <summary>
        /// 是否拥有权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasPermission")]
        public bool? HasPermission{ get; set; }

        /// <summary>
        /// 是否已收藏
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasFavorite")]
        public bool? HasFavorite{ get; set; }

        /// <summary>
        /// 其他的操作类型:
        /// 取值：
        /// ProjectIdNull -当前表未设置归属项目；
        /// NotCluster - 非系统源不支持权限申请；
        /// ProjectDisabled - 当前项目已被禁用；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherOperate")]
        public string OtherOperate{ get; set; }

        /// <summary>
        /// 被收藏数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FavoriteCount")]
        public long? FavoriteCount{ get; set; }

        /// <summary>
        /// 是否有修改业务权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasBizPermission")]
        public bool? HasBizPermission{ get; set; }

        /// <summary>
        /// 是否有修改归属项目权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasProjectPermission")]
        public bool? HasProjectPermission{ get; set; }

        /// <summary>
        /// 用户无映射账户，请先完成账户映射后再来申请。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorTips")]
        public string ErrorTips{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HasPermission", this.HasPermission);
            this.SetParamSimple(map, prefix + "HasFavorite", this.HasFavorite);
            this.SetParamSimple(map, prefix + "OtherOperate", this.OtherOperate);
            this.SetParamSimple(map, prefix + "FavoriteCount", this.FavoriteCount);
            this.SetParamSimple(map, prefix + "HasBizPermission", this.HasBizPermission);
            this.SetParamSimple(map, prefix + "HasProjectPermission", this.HasProjectPermission);
            this.SetParamSimple(map, prefix + "ErrorTips", this.ErrorTips);
        }
    }
}

