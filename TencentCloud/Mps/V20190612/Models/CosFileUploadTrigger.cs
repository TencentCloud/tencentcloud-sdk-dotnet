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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosFileUploadTrigger : AbstractModel
    {
        
        /// <summary>
        /// 工作流绑定的 COS Bucket 名，如 TopRankVideo-125xxx88。
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 工作流绑定的 COS Bucket 所属园区，如 ap-chongiqng。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 工作流绑定的输入路径目录，必须为绝对路径，即以 `/` 开头和结尾。如`/movie/201907/`，不填代表根目录`/`。
        /// </summary>
        [JsonProperty("Dir")]
        public string Dir{ get; set; }

        /// <summary>
        /// 支持的所有格式如下：
        /// 
        /// - 视频文件扩展名，支持以下选择，共15种：
        /// `.mp4`、`.avi`、`.mov`、`.wmv`、`.flv`、`.mkv`、`.mpg`、`.mpeg`、`.rm`、`.rmvb`、`.asf`、`.3gp`、`.webm`、`.ts`、`.m4v`
        /// 
        /// - 音频文件扩展名，支持以下选择，共7种：
        /// `.mp3`、`.wav`、`.aac`、`.flac`、`.ogg`、`.m4a`、`.amr`
        /// 
        /// - 字幕文件扩展名，支持以下选择，共2种：
        /// `.vtt`、`.srt`
        /// 
        /// - `*`：支持任意文件格式
        /// 
        /// - 不传或者传空列表：支持系统预设文件格式（视频：`.mp4`、`.ts`、`.flv`、`.wmv`、`.asf`、`.rm`、`.rmvb`、`.mpg`、`.mpeg`、`.3gp`、`.mov`、`.webm`、`.mkv`、`.avi`、`.m4v`，音频：`.mp3`、`.m4a`、`.flac`、`.ogg`、`.wav`、`.amr`、`.aac`，字幕：`.vtt`、`.srt`）
        /// 
        /// **注意**：
        /// 1. 如果传入的格式列表中有`*`则表示为支持任意文件格式。
        /// 2. 扩展名传入时带不带`.`都可以，比如 `.mp4` 或 `mp4` 均支持。
        /// 3. 自定义文件扩展名需满足数字、字母字符，长度在[1,64]范围内。
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Dir", this.Dir);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

