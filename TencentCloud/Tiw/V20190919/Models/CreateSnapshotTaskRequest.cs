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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSnapshotTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 白板相关参数
        /// </summary>
        [JsonProperty("Whiteboard")]
        public SnapshotWhiteboard Whiteboard{ get; set; }

        /// <summary>
        /// 白板房间 `SdkAppId`
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 白板房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 白板板书生成结果通知回调地址
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }

        /// <summary>
        /// 白板板书文件 `COS` 存储参数， 不填默认存储在公共存储桶，公共存储桶的数据仅保存3天
        /// </summary>
        [JsonProperty("COS")]
        public SnapshotCOS COS{ get; set; }

        /// <summary>
        /// 白板板书生成模式，默认为 `AllMarks`。取值说明如下：
        /// 
        /// `AllMarks` - 全量模式，即对于客户端每一次调用 `addSnapshotMark` 接口打上的白板板书生成标志全部都会生成对应的白板板书图片。
        /// 
        /// `LatestMarksOnly` - 单页去重模式，即对于客户端在同一页白板上多次调用 `addSnapshotMark` 打上的白板板书生成标志仅保留最新一次标志来生成对应白板页的白板板书图片。
        /// 
        /// （**注意：`LatestMarksOnly` 模式只有客户端使用v2.6.8及以上版本的白板SDK调用 `addSnapshotMark` 时才生效，否则即使在调用本API是指定了 `LatestMarksOnly` 模式，服务后台会使用默认的 `AllMarks` 模式生成白板板书**）
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
            this.SetParamObj(map, prefix + "COS.", this.COS);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
        }
    }
}

