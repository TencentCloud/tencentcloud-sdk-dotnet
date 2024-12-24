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

namespace TencentCloud.Asr.V20190614
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Asr.V20190614.Models;

   public class AsrClient : AbstractClient{

       private const string endpoint = "asr.tencentcloudapi.com";
       private const string version = "2019-06-14";
       private const string sdkVersion = "SDK_NET_3.0.1148";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AsrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口用于关闭语音流异步识别任务。
        /// </summary>
        /// <param name="req"><see cref="CloseAsyncRecognitionTaskRequest"/></param>
        /// <returns><see cref="CloseAsyncRecognitionTaskResponse"/></returns>
        public Task<CloseAsyncRecognitionTaskResponse> CloseAsyncRecognitionTask(CloseAsyncRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CloseAsyncRecognitionTaskResponse>(req, "CloseAsyncRecognitionTask");
        }

        /// <summary>
        /// 本接口用于关闭语音流异步识别任务。
        /// </summary>
        /// <param name="req"><see cref="CloseAsyncRecognitionTaskRequest"/></param>
        /// <returns><see cref="CloseAsyncRecognitionTaskResponse"/></returns>
        public CloseAsyncRecognitionTaskResponse CloseAsyncRecognitionTaskSync(CloseAsyncRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CloseAsyncRecognitionTaskResponse>(req, "CloseAsyncRecognitionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行关键字词表的创建。
        /// <br>•   默认每个用户最多可创建30个关键字词表。
        /// <br>•   每个关键词词表最多可添加100个词，每个词最多5个汉字或15个字符。
        /// <br>•   词表通过本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个词且不能包含标点和特殊字符。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="CreateAsrKeyWordLibResponse"/></returns>
        public Task<CreateAsrKeyWordLibResponse> CreateAsrKeyWordLib(CreateAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<CreateAsrKeyWordLibResponse>(req, "CreateAsrKeyWordLib");
        }

        /// <summary>
        /// 用户通过本接口进行关键字词表的创建。
        /// <br>•   默认每个用户最多可创建30个关键字词表。
        /// <br>•   每个关键词词表最多可添加100个词，每个词最多5个汉字或15个字符。
        /// <br>•   词表通过本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个词且不能包含标点和特殊字符。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="CreateAsrKeyWordLibResponse"/></returns>
        public CreateAsrKeyWordLibResponse CreateAsrKeyWordLibSync(CreateAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<CreateAsrKeyWordLibResponse>(req, "CreateAsrKeyWordLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行热词表的创建。
        /// <br>•   默认最多可创建30个热词表。
        /// <br>•   每个热词表最多可添加1000个词，每个词最长10个汉字或30个英文字符，不能超出限制。
        /// <br>•   热词表可以通过数组或者本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个热词且不能包含标点和特殊字符。
        /// <br>•   热词权重取值范围为[1,11]之间的整数或者100，权重越大代表该词被识别出来的概率越大。
        /// <br>• 注意:  热词权重设置为11时，当前热词将升级为超级热词，建议仅将重要且必须生效的热词设置到11，设置过多权重为11的热词将影响整体字准率。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrVocabRequest"/></param>
        /// <returns><see cref="CreateAsrVocabResponse"/></returns>
        public Task<CreateAsrVocabResponse> CreateAsrVocab(CreateAsrVocabRequest req)
        {
            return InternalRequestAsync<CreateAsrVocabResponse>(req, "CreateAsrVocab");
        }

        /// <summary>
        /// 用户通过本接口进行热词表的创建。
        /// <br>•   默认最多可创建30个热词表。
        /// <br>•   每个热词表最多可添加1000个词，每个词最长10个汉字或30个英文字符，不能超出限制。
        /// <br>•   热词表可以通过数组或者本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个热词且不能包含标点和特殊字符。
        /// <br>•   热词权重取值范围为[1,11]之间的整数或者100，权重越大代表该词被识别出来的概率越大。
        /// <br>• 注意:  热词权重设置为11时，当前热词将升级为超级热词，建议仅将重要且必须生效的热词设置到11，设置过多权重为11的热词将影响整体字准率。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrVocabRequest"/></param>
        /// <returns><see cref="CreateAsrVocabResponse"/></returns>
        public CreateAsrVocabResponse CreateAsrVocabSync(CreateAsrVocabRequest req)
        {
            return InternalRequestAsync<CreateAsrVocabResponse>(req, "CreateAsrVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于对语音流进行准实时识别，通过异步回调来返回识别结果。适用于直播审核等场景。
        /// <br>• 支持rtmp、rtsp等流媒体协议，以及各类基于http协议的直播流(不支持hls)
        /// <br>• 音频流时长无限制，服务会自动拉取音频流数据，若连续10分钟拉不到流数据时，服务会终止识别任务
        /// <br>• 服务通过回调的方式来提供识别结果，用户需要提供CallbackUrl。回调时机为一小段话(最长15秒)回调一次。
        /// <br>• 签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// <br>• 默认单账号限制并发数为20路，如您有提高并发限制的需求，请提[工单](https://console.cloud.tencent.com/workorder/category)进行咨询。
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncRecognitionTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncRecognitionTaskResponse"/></returns>
        public Task<CreateAsyncRecognitionTaskResponse> CreateAsyncRecognitionTask(CreateAsyncRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CreateAsyncRecognitionTaskResponse>(req, "CreateAsyncRecognitionTask");
        }

        /// <summary>
        /// 本接口用于对语音流进行准实时识别，通过异步回调来返回识别结果。适用于直播审核等场景。
        /// <br>• 支持rtmp、rtsp等流媒体协议，以及各类基于http协议的直播流(不支持hls)
        /// <br>• 音频流时长无限制，服务会自动拉取音频流数据，若连续10分钟拉不到流数据时，服务会终止识别任务
        /// <br>• 服务通过回调的方式来提供识别结果，用户需要提供CallbackUrl。回调时机为一小段话(最长15秒)回调一次。
        /// <br>• 签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// <br>• 默认单账号限制并发数为20路，如您有提高并发限制的需求，请提[工单](https://console.cloud.tencent.com/workorder/category)进行咨询。
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncRecognitionTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncRecognitionTaskResponse"/></returns>
        public CreateAsyncRecognitionTaskResponse CreateAsyncRecognitionTaskSync(CreateAsyncRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CreateAsyncRecognitionTaskResponse>(req, "CreateAsyncRecognitionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户使用该接口可以创建自学习模型，以供识别调用。
        /// 
        /// 注意：调用该接口后，模型会自动训练。新建模型成功后，调用ModifyCustomizationState接口修改为上线状态，即可在识别请求中使用对应模型ID。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizationRequest"/></param>
        /// <returns><see cref="CreateCustomizationResponse"/></returns>
        public Task<CreateCustomizationResponse> CreateCustomization(CreateCustomizationRequest req)
        {
            return InternalRequestAsync<CreateCustomizationResponse>(req, "CreateCustomization");
        }

        /// <summary>
        /// 用户使用该接口可以创建自学习模型，以供识别调用。
        /// 
        /// 注意：调用该接口后，模型会自动训练。新建模型成功后，调用ModifyCustomizationState接口修改为上线状态，即可在识别请求中使用对应模型ID。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizationRequest"/></param>
        /// <returns><see cref="CreateCustomizationResponse"/></returns>
        public CreateCustomizationResponse CreateCustomizationSync(CreateCustomizationRequest req)
        {
            return InternalRequestAsync<CreateCustomizationResponse>(req, "CreateCustomization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口可对较长的录音文件进行识别。如希望直接使用带界面的语音识别产品，请访问[产品体验中心](https://console.cloud.tencent.com/asr/demonstrate)。产品计费标准请查阅 [计费概述（在线版）](https://cloud.tencent.com/document/product/1093/35686)
        /// • 接口默认限频：20次/秒。此处仅限制任务提交频次，与识别结果返回时效无关
        /// • 返回时效：异步回调，非实时返回。最长3小时返回识别结果，**大多数情况下，1小时的音频1-3分钟即可完成识别**。请注意：上述返回时长不含音频下载时延，且30分钟内发送超过1000小时录音或2万条任务的情况除外
        /// • 音频格式：wav、mp3、m4a、flv、mp4、wma、3gp、amr、aac、ogg-opus、flac
        /// • 支持语言：在本页面上搜索 **EngineModelType**，或前往 [产品功能](https://cloud.tencent.com/document/product/1093/35682) 查看
        /// • 音频提交方式：本接口支持**音频 URL 、本地音频文件**两种请求方式。推荐使用 [腾讯云COS](https://cloud.tencent.com/document/product/436/38484) 来存储、生成URL并提交任务，此种方式将不产生外网和流量下行费用，可节约成本、提升任务速度（COS桶权限需要设置公有读私有写，或URL设置外部可访问）
        /// • 音频限制：音频 URL 时长不能大于5小时，文件大小不超过1GB；本地音频文件不能大于5MB
        /// • 如何获取识别结果：支持**回调或轮询**的方式获取结果，具体请参考 [录音文件识别结果查询](https://cloud.tencent.com/document/product/1093/37822)
        /// • 识别结果有效时间：识别结果在服务端保存24小时
        /// • 签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法 v3
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public Task<CreateRecTaskResponse> CreateRecTask(CreateRecTaskRequest req)
        {
            return InternalRequestAsync<CreateRecTaskResponse>(req, "CreateRecTask");
        }

        /// <summary>
        /// 本接口可对较长的录音文件进行识别。如希望直接使用带界面的语音识别产品，请访问[产品体验中心](https://console.cloud.tencent.com/asr/demonstrate)。产品计费标准请查阅 [计费概述（在线版）](https://cloud.tencent.com/document/product/1093/35686)
        /// • 接口默认限频：20次/秒。此处仅限制任务提交频次，与识别结果返回时效无关
        /// • 返回时效：异步回调，非实时返回。最长3小时返回识别结果，**大多数情况下，1小时的音频1-3分钟即可完成识别**。请注意：上述返回时长不含音频下载时延，且30分钟内发送超过1000小时录音或2万条任务的情况除外
        /// • 音频格式：wav、mp3、m4a、flv、mp4、wma、3gp、amr、aac、ogg-opus、flac
        /// • 支持语言：在本页面上搜索 **EngineModelType**，或前往 [产品功能](https://cloud.tencent.com/document/product/1093/35682) 查看
        /// • 音频提交方式：本接口支持**音频 URL 、本地音频文件**两种请求方式。推荐使用 [腾讯云COS](https://cloud.tencent.com/document/product/436/38484) 来存储、生成URL并提交任务，此种方式将不产生外网和流量下行费用，可节约成本、提升任务速度（COS桶权限需要设置公有读私有写，或URL设置外部可访问）
        /// • 音频限制：音频 URL 时长不能大于5小时，文件大小不超过1GB；本地音频文件不能大于5MB
        /// • 如何获取识别结果：支持**回调或轮询**的方式获取结果，具体请参考 [录音文件识别结果查询](https://cloud.tencent.com/document/product/1093/37822)
        /// • 识别结果有效时间：识别结果在服务端保存24小时
        /// • 签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法 v3
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public CreateRecTaskResponse CreateRecTaskSync(CreateRecTaskRequest req)
        {
            return InternalRequestAsync<CreateRecTaskResponse>(req, "CreateRecTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行关键词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="DeleteAsrKeyWordLibResponse"/></returns>
        public Task<DeleteAsrKeyWordLibResponse> DeleteAsrKeyWordLib(DeleteAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<DeleteAsrKeyWordLibResponse>(req, "DeleteAsrKeyWordLib");
        }

        /// <summary>
        /// 用户通过本接口进行关键词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="DeleteAsrKeyWordLibResponse"/></returns>
        public DeleteAsrKeyWordLibResponse DeleteAsrKeyWordLibSync(DeleteAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<DeleteAsrKeyWordLibResponse>(req, "DeleteAsrKeyWordLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行热词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrVocabRequest"/></param>
        /// <returns><see cref="DeleteAsrVocabResponse"/></returns>
        public Task<DeleteAsrVocabResponse> DeleteAsrVocab(DeleteAsrVocabRequest req)
        {
            return InternalRequestAsync<DeleteAsrVocabResponse>(req, "DeleteAsrVocab");
        }

        /// <summary>
        /// 用户通过本接口进行热词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrVocabRequest"/></param>
        /// <returns><see cref="DeleteAsrVocabResponse"/></returns>
        public DeleteAsrVocabResponse DeleteAsrVocabSync(DeleteAsrVocabRequest req)
        {
            return InternalRequestAsync<DeleteAsrVocabResponse>(req, "DeleteAsrVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口可以删除自学习模型
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizationRequest"/></param>
        /// <returns><see cref="DeleteCustomizationResponse"/></returns>
        public Task<DeleteCustomizationResponse> DeleteCustomization(DeleteCustomizationRequest req)
        {
            return InternalRequestAsync<DeleteCustomizationResponse>(req, "DeleteCustomization");
        }

        /// <summary>
        /// 用户通过该接口可以删除自学习模型
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizationRequest"/></param>
        /// <returns><see cref="DeleteCustomizationResponse"/></returns>
        public DeleteCustomizationResponse DeleteCustomizationSync(DeleteCustomizationRequest req)
        {
            return InternalRequestAsync<DeleteCustomizationResponse>(req, "DeleteCustomization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询当前在运行的语音流异步识别任务列表。
        /// <br>•   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRecognitionTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncRecognitionTasksResponse"/></returns>
        public Task<DescribeAsyncRecognitionTasksResponse> DescribeAsyncRecognitionTasks(DescribeAsyncRecognitionTasksRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRecognitionTasksResponse>(req, "DescribeAsyncRecognitionTasks");
        }

        /// <summary>
        /// 本接口用于查询当前在运行的语音流异步识别任务列表。
        /// <br>•   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRecognitionTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncRecognitionTasksResponse"/></returns>
        public DescribeAsyncRecognitionTasksResponse DescribeAsyncRecognitionTasksSync(DescribeAsyncRecognitionTasksRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRecognitionTasksResponse>(req, "DescribeAsyncRecognitionTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用录音文件识别请求接口后，有回调和轮询两种方式获取识别结果。
        /// • **注意任务有效期为24小时，超过24小时的任务请不要再查询，且不要依赖TaskId作为业务唯一ID，不同日期可能出现重复TaskId。**
        /// • 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[ 录音识别结果回调 ](https://cloud.tencent.com/document/product/1093/52632)。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// •   请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// •   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// •   默认接口请求频率限制：50次/秒，如您有提高请求频率限制的需求，请提[工单](https://console.cloud.tencent.com/workorder/category)进行咨询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 调用录音文件识别请求接口后，有回调和轮询两种方式获取识别结果。
        /// • **注意任务有效期为24小时，超过24小时的任务请不要再查询，且不要依赖TaskId作为业务唯一ID，不同日期可能出现重复TaskId。**
        /// • 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[ 录音识别结果回调 ](https://cloud.tencent.com/document/product/1093/52632)。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// •   请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// •   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// •   默认接口请求频率限制：50次/秒，如您有提高请求频率限制的需求，请提[工单](https://console.cloud.tencent.com/workorder/category)进行咨询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行热词表的下载，获得词表权重文件形式的 base64 值，文件形式为通过 “|” 分割的词和权重，即 word|weight 的形式。
        /// </summary>
        /// <param name="req"><see cref="DownloadAsrVocabRequest"/></param>
        /// <returns><see cref="DownloadAsrVocabResponse"/></returns>
        public Task<DownloadAsrVocabResponse> DownloadAsrVocab(DownloadAsrVocabRequest req)
        {
            return InternalRequestAsync<DownloadAsrVocabResponse>(req, "DownloadAsrVocab");
        }

        /// <summary>
        /// 用户通过本接口进行热词表的下载，获得词表权重文件形式的 base64 值，文件形式为通过 “|” 分割的词和权重，即 word|weight 的形式。
        /// </summary>
        /// <param name="req"><see cref="DownloadAsrVocabRequest"/></param>
        /// <returns><see cref="DownloadAsrVocabResponse"/></returns>
        public DownloadAsrVocabResponse DownloadAsrVocabSync(DownloadAsrVocabRequest req)
        {
            return InternalRequestAsync<DownloadAsrVocabResponse>(req, "DownloadAsrVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口可以下载自学习模型的语料
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomizationRequest"/></param>
        /// <returns><see cref="DownloadCustomizationResponse"/></returns>
        public Task<DownloadCustomizationResponse> DownloadCustomization(DownloadCustomizationRequest req)
        {
            return InternalRequestAsync<DownloadCustomizationResponse>(req, "DownloadCustomization");
        }

        /// <summary>
        /// 用户通过该接口可以下载自学习模型的语料
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomizationRequest"/></param>
        /// <returns><see cref="DownloadCustomizationResponse"/></returns>
        public DownloadCustomizationResponse DownloadCustomizationSync(DownloadCustomizationRequest req)
        {
            return InternalRequestAsync<DownloadCustomizationResponse>(req, "DownloadCustomization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的关键词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrKeyWordLibListRequest"/></param>
        /// <returns><see cref="GetAsrKeyWordLibListResponse"/></returns>
        public Task<GetAsrKeyWordLibListResponse> GetAsrKeyWordLibList(GetAsrKeyWordLibListRequest req)
        {
            return InternalRequestAsync<GetAsrKeyWordLibListResponse>(req, "GetAsrKeyWordLibList");
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的关键词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrKeyWordLibListRequest"/></param>
        /// <returns><see cref="GetAsrKeyWordLibListResponse"/></returns>
        public GetAsrKeyWordLibListResponse GetAsrKeyWordLibListSync(GetAsrKeyWordLibListRequest req)
        {
            return InternalRequestAsync<GetAsrKeyWordLibListResponse>(req, "GetAsrKeyWordLibList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户根据词表的ID可以获取对应的热词表信息
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabRequest"/></param>
        /// <returns><see cref="GetAsrVocabResponse"/></returns>
        public Task<GetAsrVocabResponse> GetAsrVocab(GetAsrVocabRequest req)
        {
            return InternalRequestAsync<GetAsrVocabResponse>(req, "GetAsrVocab");
        }

        /// <summary>
        /// 用户根据词表的ID可以获取对应的热词表信息
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabRequest"/></param>
        /// <returns><see cref="GetAsrVocabResponse"/></returns>
        public GetAsrVocabResponse GetAsrVocabSync(GetAsrVocabRequest req)
        {
            return InternalRequestAsync<GetAsrVocabResponse>(req, "GetAsrVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的热词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabListRequest"/></param>
        /// <returns><see cref="GetAsrVocabListResponse"/></returns>
        public Task<GetAsrVocabListResponse> GetAsrVocabList(GetAsrVocabListRequest req)
        {
            return InternalRequestAsync<GetAsrVocabListResponse>(req, "GetAsrVocabList");
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的热词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabListRequest"/></param>
        /// <returns><see cref="GetAsrVocabListResponse"/></returns>
        public GetAsrVocabListResponse GetAsrVocabListSync(GetAsrVocabListRequest req)
        {
            return InternalRequestAsync<GetAsrVocabListResponse>(req, "GetAsrVocabList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自学习模型列表
        /// </summary>
        /// <param name="req"><see cref="GetCustomizationListRequest"/></param>
        /// <returns><see cref="GetCustomizationListResponse"/></returns>
        public Task<GetCustomizationListResponse> GetCustomizationList(GetCustomizationListRequest req)
        {
            return InternalRequestAsync<GetCustomizationListResponse>(req, "GetCustomizationList");
        }

        /// <summary>
        /// 查询自学习模型列表
        /// </summary>
        /// <param name="req"><see cref="GetCustomizationListRequest"/></param>
        /// <returns><see cref="GetCustomizationListResponse"/></returns>
        public GetCustomizationListResponse GetCustomizationListSync(GetCustomizationListRequest req)
        {
            return InternalRequestAsync<GetCustomizationListResponse>(req, "GetCustomizationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过自学习模型id获取自学习模型详细信息
        /// </summary>
        /// <param name="req"><see cref="GetModelInfoRequest"/></param>
        /// <returns><see cref="GetModelInfoResponse"/></returns>
        public Task<GetModelInfoResponse> GetModelInfo(GetModelInfoRequest req)
        {
            return InternalRequestAsync<GetModelInfoResponse>(req, "GetModelInfo");
        }

        /// <summary>
        /// 通过自学习模型id获取自学习模型详细信息
        /// </summary>
        /// <param name="req"><see cref="GetModelInfoRequest"/></param>
        /// <returns><see cref="GetModelInfoResponse"/></returns>
        public GetModelInfoResponse GetModelInfoSync(GetModelInfoRequest req)
        {
            return InternalRequestAsync<GetModelInfoResponse>(req, "GetModelInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户用量
        /// </summary>
        /// <param name="req"><see cref="GetUsageByDateRequest"/></param>
        /// <returns><see cref="GetUsageByDateResponse"/></returns>
        public Task<GetUsageByDateResponse> GetUsageByDate(GetUsageByDateRequest req)
        {
            return InternalRequestAsync<GetUsageByDateResponse>(req, "GetUsageByDate");
        }

        /// <summary>
        /// 查询用户用量
        /// </summary>
        /// <param name="req"><see cref="GetUsageByDateRequest"/></param>
        /// <returns><see cref="GetUsageByDateResponse"/></returns>
        public GetUsageByDateResponse GetUsageByDateSync(GetUsageByDateRequest req)
        {
            return InternalRequestAsync<GetUsageByDateResponse>(req, "GetUsageByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口可以更新自学习模型，如模型名称、模型类型、模型语料。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationRequest"/></param>
        /// <returns><see cref="ModifyCustomizationResponse"/></returns>
        public Task<ModifyCustomizationResponse> ModifyCustomization(ModifyCustomizationRequest req)
        {
            return InternalRequestAsync<ModifyCustomizationResponse>(req, "ModifyCustomization");
        }

        /// <summary>
        /// 用户通过该接口可以更新自学习模型，如模型名称、模型类型、模型语料。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationRequest"/></param>
        /// <returns><see cref="ModifyCustomizationResponse"/></returns>
        public ModifyCustomizationResponse ModifyCustomizationSync(ModifyCustomizationRequest req)
        {
            return InternalRequestAsync<ModifyCustomizationResponse>(req, "ModifyCustomization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过该接口，用户可以修改自学习模型状态，上下线自学习模型
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationStateRequest"/></param>
        /// <returns><see cref="ModifyCustomizationStateResponse"/></returns>
        public Task<ModifyCustomizationStateResponse> ModifyCustomizationState(ModifyCustomizationStateRequest req)
        {
            return InternalRequestAsync<ModifyCustomizationStateResponse>(req, "ModifyCustomizationState");
        }

        /// <summary>
        /// 通过该接口，用户可以修改自学习模型状态，上下线自学习模型
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationStateRequest"/></param>
        /// <returns><see cref="ModifyCustomizationStateResponse"/></returns>
        public ModifyCustomizationStateResponse ModifyCustomizationStateSync(ModifyCustomizationStateRequest req)
        {
            return InternalRequestAsync<ModifyCustomizationStateResponse>(req, "ModifyCustomizationState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于对60秒之内的短音频文件进行识别。
        /// •   支持中文普通话、英语、粤语、日语、越南语、马来语、印度尼西亚语、菲律宾语、泰语、葡萄牙语、土耳其语、阿拉伯语、印地语、法语、德语、上海话、四川话、武汉话、贵阳话、昆明话、西安话、郑州话、太原话、兰州话、银川话、西宁话、南京话、合肥话、南昌话、长沙话、苏州话、杭州话、济南话、天津话、石家庄话、黑龙江话、吉林话、辽宁话。
        /// •   支持本地语音文件上传和语音URL上传两种请求方式，音频时长不能超过60s，音频文件大小不能超过3MB。推荐使用 [腾讯云COS](https://cloud.tencent.com/document/product/436/38484) 来存储音频、生成URL并提交请求，此种方式会走内网下载音频，极大降低整体请求时延；并且不会产生外网和流量下行费用，可节约成本（COS桶权限需要设置公有读私有写，或URL设置时效访问签名）
        /// •   音频格式支持wav、pcm、ogg-opus、speex、silk、mp3、m4a、aac、 amr。
        /// •   请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// •   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// •   默认接口请求频率限制：30次/秒，如您有提高请求频率限制的需求，请[前往购买](https://buy.cloud.tencent.com/asr)。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public Task<SentenceRecognitionResponse> SentenceRecognition(SentenceRecognitionRequest req)
        {
            return InternalRequestAsync<SentenceRecognitionResponse>(req, "SentenceRecognition");
        }

        /// <summary>
        /// 本接口用于对60秒之内的短音频文件进行识别。
        /// •   支持中文普通话、英语、粤语、日语、越南语、马来语、印度尼西亚语、菲律宾语、泰语、葡萄牙语、土耳其语、阿拉伯语、印地语、法语、德语、上海话、四川话、武汉话、贵阳话、昆明话、西安话、郑州话、太原话、兰州话、银川话、西宁话、南京话、合肥话、南昌话、长沙话、苏州话、杭州话、济南话、天津话、石家庄话、黑龙江话、吉林话、辽宁话。
        /// •   支持本地语音文件上传和语音URL上传两种请求方式，音频时长不能超过60s，音频文件大小不能超过3MB。推荐使用 [腾讯云COS](https://cloud.tencent.com/document/product/436/38484) 来存储音频、生成URL并提交请求，此种方式会走内网下载音频，极大降低整体请求时延；并且不会产生外网和流量下行费用，可节约成本（COS桶权限需要设置公有读私有写，或URL设置时效访问签名）
        /// •   音频格式支持wav、pcm、ogg-opus、speex、silk、mp3、m4a、aac、 amr。
        /// •   请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// •   签名方法参考 [公共参数](https://cloud.tencent.com/document/api/1093/35640) 中签名方法v3。
        /// •   默认接口请求频率限制：30次/秒，如您有提高请求频率限制的需求，请[前往购买](https://buy.cloud.tencent.com/asr)。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public SentenceRecognitionResponse SentenceRecognitionSync(SentenceRecognitionRequest req)
        {
            return InternalRequestAsync<SentenceRecognitionResponse>(req, "SentenceRecognition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过该接口可以设置热词表的默认状态。初始状态为0，用户可设置状态为1，即为默认状态。默认状态表示用户在请求识别时，如不设置热词表ID，则默认使用状态为1的热词表。
        /// </summary>
        /// <param name="req"><see cref="SetVocabStateRequest"/></param>
        /// <returns><see cref="SetVocabStateResponse"/></returns>
        public Task<SetVocabStateResponse> SetVocabState(SetVocabStateRequest req)
        {
            return InternalRequestAsync<SetVocabStateResponse>(req, "SetVocabState");
        }

        /// <summary>
        /// 用户通过该接口可以设置热词表的默认状态。初始状态为0，用户可设置状态为1，即为默认状态。默认状态表示用户在请求识别时，如不设置热词表ID，则默认使用状态为1的热词表。
        /// </summary>
        /// <param name="req"><see cref="SetVocabStateRequest"/></param>
        /// <returns><see cref="SetVocabStateResponse"/></returns>
        public SetVocabStateResponse SetVocabStateSync(SetVocabStateRequest req)
        {
            return InternalRequestAsync<SetVocabStateResponse>(req, "SetVocabState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行对应的关键词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="UpdateAsrKeyWordLibResponse"/></returns>
        public Task<UpdateAsrKeyWordLibResponse> UpdateAsrKeyWordLib(UpdateAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<UpdateAsrKeyWordLibResponse>(req, "UpdateAsrKeyWordLib");
        }

        /// <summary>
        /// 用户通过本接口进行对应的关键词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrKeyWordLibRequest"/></param>
        /// <returns><see cref="UpdateAsrKeyWordLibResponse"/></returns>
        public UpdateAsrKeyWordLibResponse UpdateAsrKeyWordLibSync(UpdateAsrKeyWordLibRequest req)
        {
            return InternalRequestAsync<UpdateAsrKeyWordLibResponse>(req, "UpdateAsrKeyWordLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口进行对应的词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrVocabRequest"/></param>
        /// <returns><see cref="UpdateAsrVocabResponse"/></returns>
        public Task<UpdateAsrVocabResponse> UpdateAsrVocab(UpdateAsrVocabRequest req)
        {
            return InternalRequestAsync<UpdateAsrVocabResponse>(req, "UpdateAsrVocab");
        }

        /// <summary>
        /// 用户通过本接口进行对应的词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrVocabRequest"/></param>
        /// <returns><see cref="UpdateAsrVocabResponse"/></returns>
        public UpdateAsrVocabResponse UpdateAsrVocabSync(UpdateAsrVocabRequest req)
        {
            return InternalRequestAsync<UpdateAsrVocabResponse>(req, "UpdateAsrVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过比对两段音频内说话人的声纹，得到一个打分，可通过打分判断两段音频声纹相似度,  打分区间[0 - 100]。 音频要求：16k采样率， 16bit位深，pcm或者wav格式， 单声道，总时长不超过30秒的音频，base64编码数据大小不超过2M，音频内容只有一个说话人声音，并且尽可能清晰，这样结果更加准确。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintCompareRequest"/></param>
        /// <returns><see cref="VoicePrintCompareResponse"/></returns>
        public Task<VoicePrintCompareResponse> VoicePrintCompare(VoicePrintCompareRequest req)
        {
            return InternalRequestAsync<VoicePrintCompareResponse>(req, "VoicePrintCompare");
        }

        /// <summary>
        /// 通过比对两段音频内说话人的声纹，得到一个打分，可通过打分判断两段音频声纹相似度,  打分区间[0 - 100]。 音频要求：16k采样率， 16bit位深，pcm或者wav格式， 单声道，总时长不超过30秒的音频，base64编码数据大小不超过2M，音频内容只有一个说话人声音，并且尽可能清晰，这样结果更加准确。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintCompareRequest"/></param>
        /// <returns><see cref="VoicePrintCompareResponse"/></returns>
        public VoicePrintCompareResponse VoicePrintCompareSync(VoicePrintCompareRequest req)
        {
            return InternalRequestAsync<VoicePrintCompareResponse>(req, "VoicePrintCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计并返回注册的说话人id总数
        /// </summary>
        /// <param name="req"><see cref="VoicePrintCountRequest"/></param>
        /// <returns><see cref="VoicePrintCountResponse"/></returns>
        public Task<VoicePrintCountResponse> VoicePrintCount(VoicePrintCountRequest req)
        {
            return InternalRequestAsync<VoicePrintCountResponse>(req, "VoicePrintCount");
        }

        /// <summary>
        /// 统计并返回注册的说话人id总数
        /// </summary>
        /// <param name="req"><see cref="VoicePrintCountRequest"/></param>
        /// <returns><see cref="VoicePrintCountResponse"/></returns>
        public VoicePrintCountResponse VoicePrintCountSync(VoicePrintCountRequest req)
        {
            return InternalRequestAsync<VoicePrintCountResponse>(req, "VoicePrintCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于以删除已经注册的说话人信息（删除之后，原有的说话人ID和说话人音频数据都会失效）
        /// </summary>
        /// <param name="req"><see cref="VoicePrintDeleteRequest"/></param>
        /// <returns><see cref="VoicePrintDeleteResponse"/></returns>
        public Task<VoicePrintDeleteResponse> VoicePrintDelete(VoicePrintDeleteRequest req)
        {
            return InternalRequestAsync<VoicePrintDeleteResponse>(req, "VoicePrintDelete");
        }

        /// <summary>
        /// 本接口用于以删除已经注册的说话人信息（删除之后，原有的说话人ID和说话人音频数据都会失效）
        /// </summary>
        /// <param name="req"><see cref="VoicePrintDeleteRequest"/></param>
        /// <returns><see cref="VoicePrintDeleteResponse"/></returns>
        public VoicePrintDeleteResponse VoicePrintDeleteSync(VoicePrintDeleteRequest req)
        {
            return InternalRequestAsync<VoicePrintDeleteResponse>(req, "VoicePrintDelete")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 说话人注册接口用于注册一个指定音频，生成一个唯一的说话人id，后续可通过说话人验证接口验证其它音频和已有的说话人ID匹配度，注册时可指定说话人昵称，方便标识说话人ID，  说话人昵称可重复配置。 
        /// （注: 一个appid最多可以注册1000个说话人ID，一个说话人ID仅支持一条音频注册，后续可通过更新接口进行更新）
        /// 
        /// 使用须知
        /// 支持的输入格式：编码文件(PCM, WAV)、16 bit采样位数、单声道（mono）。
        /// 
        /// 支持的音频采样率：16000 Hz。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintEnrollRequest"/></param>
        /// <returns><see cref="VoicePrintEnrollResponse"/></returns>
        public Task<VoicePrintEnrollResponse> VoicePrintEnroll(VoicePrintEnrollRequest req)
        {
            return InternalRequestAsync<VoicePrintEnrollResponse>(req, "VoicePrintEnroll");
        }

        /// <summary>
        /// 说话人注册接口用于注册一个指定音频，生成一个唯一的说话人id，后续可通过说话人验证接口验证其它音频和已有的说话人ID匹配度，注册时可指定说话人昵称，方便标识说话人ID，  说话人昵称可重复配置。 
        /// （注: 一个appid最多可以注册1000个说话人ID，一个说话人ID仅支持一条音频注册，后续可通过更新接口进行更新）
        /// 
        /// 使用须知
        /// 支持的输入格式：编码文件(PCM, WAV)、16 bit采样位数、单声道（mono）。
        /// 
        /// 支持的音频采样率：16000 Hz。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintEnrollRequest"/></param>
        /// <returns><see cref="VoicePrintEnrollResponse"/></returns>
        public VoicePrintEnrollResponse VoicePrintEnrollSync(VoicePrintEnrollRequest req)
        {
            return InternalRequestAsync<VoicePrintEnrollResponse>(req, "VoicePrintEnroll")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 说话人验证1:N接口，可以通过传入一段说话人音频，并且指定已存在的groupId, 和返回topN,  接口返回groupId内所有声纹和传入音频声纹比对打分TopN的结果。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintGroupVerifyRequest"/></param>
        /// <returns><see cref="VoicePrintGroupVerifyResponse"/></returns>
        public Task<VoicePrintGroupVerifyResponse> VoicePrintGroupVerify(VoicePrintGroupVerifyRequest req)
        {
            return InternalRequestAsync<VoicePrintGroupVerifyResponse>(req, "VoicePrintGroupVerify");
        }

        /// <summary>
        /// 说话人验证1:N接口，可以通过传入一段说话人音频，并且指定已存在的groupId, 和返回topN,  接口返回groupId内所有声纹和传入音频声纹比对打分TopN的结果。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintGroupVerifyRequest"/></param>
        /// <returns><see cref="VoicePrintGroupVerifyResponse"/></returns>
        public VoicePrintGroupVerifyResponse VoicePrintGroupVerifySync(VoicePrintGroupVerifyRequest req)
        {
            return InternalRequestAsync<VoicePrintGroupVerifyResponse>(req, "VoicePrintGroupVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于更新和覆盖已注册的音频数据和说话人昵称，更新后原有的音频数据将失效。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintUpdateRequest"/></param>
        /// <returns><see cref="VoicePrintUpdateResponse"/></returns>
        public Task<VoicePrintUpdateResponse> VoicePrintUpdate(VoicePrintUpdateRequest req)
        {
            return InternalRequestAsync<VoicePrintUpdateResponse>(req, "VoicePrintUpdate");
        }

        /// <summary>
        /// 本接口用于更新和覆盖已注册的音频数据和说话人昵称，更新后原有的音频数据将失效。
        /// </summary>
        /// <param name="req"><see cref="VoicePrintUpdateRequest"/></param>
        /// <returns><see cref="VoicePrintUpdateResponse"/></returns>
        public VoicePrintUpdateResponse VoicePrintUpdateSync(VoicePrintUpdateRequest req)
        {
            return InternalRequestAsync<VoicePrintUpdateResponse>(req, "VoicePrintUpdate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验传入音频与已注册音频的匹配程度，通过指定说话人ID（VoicePrintId）和一段音频进行音频和说话人的匹配度判断
        /// </summary>
        /// <param name="req"><see cref="VoicePrintVerifyRequest"/></param>
        /// <returns><see cref="VoicePrintVerifyResponse"/></returns>
        public Task<VoicePrintVerifyResponse> VoicePrintVerify(VoicePrintVerifyRequest req)
        {
            return InternalRequestAsync<VoicePrintVerifyResponse>(req, "VoicePrintVerify");
        }

        /// <summary>
        /// 本接口用于校验传入音频与已注册音频的匹配程度，通过指定说话人ID（VoicePrintId）和一段音频进行音频和说话人的匹配度判断
        /// </summary>
        /// <param name="req"><see cref="VoicePrintVerifyRequest"/></param>
        /// <returns><see cref="VoicePrintVerifyResponse"/></returns>
        public VoicePrintVerifyResponse VoicePrintVerifySync(VoicePrintVerifyRequest req)
        {
            return InternalRequestAsync<VoicePrintVerifyResponse>(req, "VoicePrintVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
