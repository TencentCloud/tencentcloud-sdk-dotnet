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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LibraryExtension : AbstractModel
    {
        
        /// <summary>
        /// true 为文件类型媒体库，可存储任何类型文件；false 为媒体类型媒体库，仅可存储照片和视频类型文件。默认为 false。在媒体库创建后不能修改。
        /// </summary>
        [JsonProperty("IsFileLibrary")]
        public bool? IsFileLibrary{ get; set; }

        /// <summary>
        /// true 为多租户空间媒体库，可创建多个租户空间；false 为单租户空间媒体库，不能创建租户空间，仅可使用默认的单一租户空间。默认为 false。在媒体库创建后不能修改。
        /// </summary>
        [JsonProperty("IsMultiSpace")]
        public bool? IsMultiSpace{ get; set; }

        /// <summary>
        /// 保存至 COS 对象存储的文件的存储类型，仅支持 STANDARD、STANDARD_IA、INTELLIGENT_TIERING、MAZ_STANDARD、MAZ_STANDARD_IA 和 MAZ_INTELLIGENT_TIERING，默认为 STANDARD，当使用多 AZ 存储桶时将自动使用 MAZ_ 开头的用于多 AZ 的存储类型，否则自动使用非 MAZ_ 开头的用于非多 AZ 的存储类型。当指定智能分层存储 INTELLIGENT_TIERING 或 MAZ_INTELLIGENT_TIERING 时，需要事先为存储桶开启智能分层存储，否则将返回失败。在媒体库创建后不能修改。
        /// </summary>
        [JsonProperty("CosStorageClass")]
        public string CosStorageClass{ get; set; }

        /// <summary>
        /// 是否开启回收站功能。默认为 false。
        /// </summary>
        [JsonProperty("UseRecycleBin")]
        public bool? UseRecycleBin{ get; set; }

        /// <summary>
        /// 当开启回收站时，自动删除回收站项目的天数，不能超过 1095（3 年），指定为 0 则不自动删除，默认为 0。当未开启回收站时，该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRemoveRecycledDays")]
        public ulong? AutoRemoveRecycledDays{ get; set; }

        /// <summary>
        /// 是否启用文件路径搜索功能。默认为 false。
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }

        /// <summary>
        /// 设置媒体库或租户空间配额且配额小于已使用存储量时，是否拒绝设置请求。默认为 false。
        /// </summary>
        [JsonProperty("DenyOnQuotaLessThanUsage")]
        public bool? DenyOnQuotaLessThanUsage{ get; set; }

        /// <summary>
        /// 是否开启历史版本。默认为 false。
        /// </summary>
        [JsonProperty("EnableFileHistory")]
        public bool? EnableFileHistory{ get; set; }

        /// <summary>
        /// 当开启历史版本时，指定单个文件保留的历史版本的数量上限，不能超过 999，指定为 0 则不限制，默认为 0。当未开启历史版本时，该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileHistoryCount")]
        public ulong? FileHistoryCount{ get; set; }

        /// <summary>
        /// 当开启历史版本时，指定历史版本保留的最长天数，不能超过 999，指定为 0 则不限制，默认为 0。当未开启历史版本时，该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileHistoryExpireDay")]
        public ulong? FileHistoryExpireDay{ get; set; }

        /// <summary>
        /// 目录或文件名的最长长度，不能超过 255，默认为 255。修改该参数不会影响存量目录或文件名，即如果将该字段的值改小，已经存在的长度超过目标值的目录或文件名不会发生变化。
        /// </summary>
        [JsonProperty("MaxDirFileNameLength")]
        public ulong? MaxDirFileNameLength{ get; set; }

        /// <summary>
        /// 是否开启公有读，开启后读操作无需使用访问令牌，默认为 false。仅单租户空间媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPublicRead")]
        public bool? IsPublicRead{ get; set; }

        /// <summary>
        /// 媒体类型媒体库是否开启多相簿，开启后可创建一级目录（即相簿）且媒体文件只能保存在各相簿中，否则不能创建相簿且媒体文件只能保存在根目录。默认为 false。仅单租户空间媒体类型媒体库支持该属性，否则该属性为 null。在媒体库创建后不能修改。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsMultiAlbum")]
        public bool? IsMultiAlbum{ get; set; }

        /// <summary>
        /// 媒体类型媒体库是否允许上传照片，默认为 true。仅单租户空间媒体类型媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowPhoto")]
        public bool? AllowPhoto{ get; set; }

        /// <summary>
        /// 当媒体类型媒体库允许上传照片时，指定允许的扩展名，默认为空数组，此时将根据文件扩展名对应的 MIME 类型自动判断。仅单租户空间媒体类型媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowPhotoExtName")]
        public string[] AllowPhotoExtName{ get; set; }

        /// <summary>
        /// 媒体类型媒体库是否允许上传视频，默认为 true。仅单租户空间媒体类型媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowVideo")]
        public bool? AllowVideo{ get; set; }

        /// <summary>
        /// 当媒体类型媒体库允许上传视频时，指定允许的扩展名，默认为空数组，此时将根据文件扩展名对应的 MIME 类型自动判断。仅单租户空间媒体类型媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowVideoExtName")]
        public string[] AllowVideoExtName{ get; set; }

        /// <summary>
        /// 指定文件类型媒体库允许的文件扩展名，默认为空数组，此时允许上传所有类型文件。仅单租户空间文件类型媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowFileExtName")]
        public string[] AllowFileExtName{ get; set; }

        /// <summary>
        /// 照片上传时是否进行敏感内容鉴定，默认为 false。仅单租户空间媒体库支持该属性，否则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecognizeSensitiveContent")]
        public bool? RecognizeSensitiveContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsFileLibrary", this.IsFileLibrary);
            this.SetParamSimple(map, prefix + "IsMultiSpace", this.IsMultiSpace);
            this.SetParamSimple(map, prefix + "CosStorageClass", this.CosStorageClass);
            this.SetParamSimple(map, prefix + "UseRecycleBin", this.UseRecycleBin);
            this.SetParamSimple(map, prefix + "AutoRemoveRecycledDays", this.AutoRemoveRecycledDays);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
            this.SetParamSimple(map, prefix + "DenyOnQuotaLessThanUsage", this.DenyOnQuotaLessThanUsage);
            this.SetParamSimple(map, prefix + "EnableFileHistory", this.EnableFileHistory);
            this.SetParamSimple(map, prefix + "FileHistoryCount", this.FileHistoryCount);
            this.SetParamSimple(map, prefix + "FileHistoryExpireDay", this.FileHistoryExpireDay);
            this.SetParamSimple(map, prefix + "MaxDirFileNameLength", this.MaxDirFileNameLength);
            this.SetParamSimple(map, prefix + "IsPublicRead", this.IsPublicRead);
            this.SetParamSimple(map, prefix + "IsMultiAlbum", this.IsMultiAlbum);
            this.SetParamSimple(map, prefix + "AllowPhoto", this.AllowPhoto);
            this.SetParamArraySimple(map, prefix + "AllowPhotoExtName.", this.AllowPhotoExtName);
            this.SetParamSimple(map, prefix + "AllowVideo", this.AllowVideo);
            this.SetParamArraySimple(map, prefix + "AllowVideoExtName.", this.AllowVideoExtName);
            this.SetParamArraySimple(map, prefix + "AllowFileExtName.", this.AllowFileExtName);
            this.SetParamSimple(map, prefix + "RecognizeSensitiveContent", this.RecognizeSensitiveContent);
        }
    }
}

