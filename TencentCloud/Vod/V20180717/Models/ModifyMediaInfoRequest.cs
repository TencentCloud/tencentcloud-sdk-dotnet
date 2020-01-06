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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMediaInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件唯一标识。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 媒体文件名称，最长 64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 媒体文件描述，最长 128 个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 媒体文件分类 ID。
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// 媒体文件过期时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。填“9999-12-31T23:59:59Z”表示永不过期。过期后该媒体文件及其相关资源（转码结果、雪碧图等）将被永久删除。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 视频封面图片文件（如 jpeg, png 等）进行 [Base64](https://tools.ietf.org/html/rfc4648) 编码后的字符串，仅支持 gif、jpeg、png 三种图片格式。
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

        /// <summary>
        /// 新增的一组视频打点信息，如果某个偏移时间已存在打点，则会进行覆盖操作，单个媒体文件最多 100 个打点信息。同一个请求里，AddKeyFrameDescs 的时间偏移参数必须与 DeleteKeyFrameDescs 都不同。
        /// </summary>
        [JsonProperty("AddKeyFrameDescs")]
        public MediaKeyFrameDescItem[] AddKeyFrameDescs{ get; set; }

        /// <summary>
        /// 要删除的一组视频打点信息的时间偏移，单位：秒。同一个请求里，AddKeyFrameDescs 的时间偏移参数必须与 DeleteKeyFrameDescs 都不同。
        /// </summary>
        [JsonProperty("DeleteKeyFrameDescs")]
        public float?[] DeleteKeyFrameDescs{ get; set; }

        /// <summary>
        /// 取值 1 表示清空视频打点信息，其他值无意义。
        /// 同一个请求里，ClearKeyFrameDescs 与 AddKeyFrameDescs 不能同时出现。
        /// </summary>
        [JsonProperty("ClearKeyFrameDescs")]
        public long? ClearKeyFrameDescs{ get; set; }

        /// <summary>
        /// 新增的一组标签，单个媒体文件最多 16 个标签，单个标签最多 16 个字符。同一个请求里，AddTags 参数必须与 DeleteTags 都不同。
        /// </summary>
        [JsonProperty("AddTags")]
        public string[] AddTags{ get; set; }

        /// <summary>
        /// 要删除的一组标签。同一个请求里，AddTags 参数必须与 DeleteTags 都不同。
        /// </summary>
        [JsonProperty("DeleteTags")]
        public string[] DeleteTags{ get; set; }

        /// <summary>
        /// 取值 1 表示清空媒体文件所有标签，其他值无意义。
        /// 同一个请求里，ClearTags 与 AddTags 不能同时出现。
        /// </summary>
        [JsonProperty("ClearTags")]
        public long? ClearTags{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID 。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CoverData", this.CoverData);
            this.SetParamArrayObj(map, prefix + "AddKeyFrameDescs.", this.AddKeyFrameDescs);
            this.SetParamArraySimple(map, prefix + "DeleteKeyFrameDescs.", this.DeleteKeyFrameDescs);
            this.SetParamSimple(map, prefix + "ClearKeyFrameDescs", this.ClearKeyFrameDescs);
            this.SetParamArraySimple(map, prefix + "AddTags.", this.AddTags);
            this.SetParamArraySimple(map, prefix + "DeleteTags.", this.DeleteTags);
            this.SetParamSimple(map, prefix + "ClearTags", this.ClearTags);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

